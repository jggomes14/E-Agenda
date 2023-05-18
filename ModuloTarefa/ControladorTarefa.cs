using E_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir uma nova Tarefa";  } }
        public override string ToolTipEditar  { get { return "Editar Tarefa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa existente"; } }

        public override void Editar()
        {
            
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            DialogResult OpcaoEscolhida = telaTarefa.ShowDialog();

            if (OpcaoEscolhida == DialogResult.OK) 
            {
                MessageBox.Show("Informações Gravadas com Sucesso!");
            
            }
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }
    }
}
