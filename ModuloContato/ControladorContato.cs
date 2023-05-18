using E_Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoContol listagemContato;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir um novo Contato"; } }

        public override string ToolTipEditar { get { return "Editar Contato existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Contato existente"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult OpcaoEscolhida = telaContato.ShowDialog();

            if (OpcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;
                repositorioContato.Inserir(contato);
                CarregarContatos();
                MessageBox.Show("Informações Gravadas com Sucesso!");

            }


        }
        public override void Editar()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = listagemContato.ObterContatoSelecionado();
            DialogResult OpcaoEscolhida = telaContato.ShowDialog();
            if (OpcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;
                repositorioContato.Editar(contato);
                CarregarContatos();
                MessageBox.Show("Informações Gravadas com Sucesso!");

            }
        }
        public override void Excluir()
        {

            Contato contato = listagemContato.ObterContatoSelecionado();
            DialogResult OpcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (OpcaoEscolhida == DialogResult.OK)
            {
                
                repositorioContato.Excluir(contato);
                CarregarContatos();
                MessageBox.Show("Contato Removido com Sucesso!");

            }
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListagemContatoContol();

            CarregarContatos();
            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

       
    }
}
