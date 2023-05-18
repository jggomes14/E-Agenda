using E_Agenda.Compartilhado;
using E_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListagemCompromissoControl listagemCompromisso;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso)
        {
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso existente"; } }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();

            DialogResult OpcaoEscolhida = telaCompromisso.ShowDialog();

            if (OpcaoEscolhida == DialogResult.OK)
            {
                List<Contato> contatos = new TelaCompromissoForm(contatos);
                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Inserir(compromisso);
                CarregarCompromissos();
                MessageBox.Show("Compromisso Gravado com Sucesso!");

            }


        }
        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.Compromisso = listagemCompromisso.ObterCompromissoSelecionado();
            DialogResult OpcaoEscolhida = telaCompromisso.ShowDialog();
            if (OpcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Editar(compromisso);
                CarregarContatos();
                MessageBox.Show("Compromisso Gravado com Sucesso!");

            }
        }
        public override void Excluir()
        {

            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();
            DialogResult OpcaoEscolhida = MessageBox.Show($"Deseja excluir o compromisso {compromisso.assunto}?", "Exclusão de Compromissos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (OpcaoEscolhida == DialogResult.OK)
            {

                repositorioCompromisso.Excluir(compromisso);
                CarregarCompromissos();
                MessageBox.Show("Compromisso Removido com Sucesso!");

            }
        }
        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarContatos();
            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }


    }
}
