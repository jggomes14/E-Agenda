using E_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Agenda.ModuloContato;

namespace E_Agenda.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {

        private RepositorioContato repositorioContato;
        private Contato contato;
        private Compromisso compromisso;
        public TelaCompromissoForm(List<Contato> contatos)
        {
            InitializeComponent();
            CarregarContatos(contatos);
        }

        private void CarregarContatos(List<Contato> contatos)
        {
            DropDeContatos.Items.Clear();
            foreach (var item in contatos)
            {
                DropDeContatos.Items.Add(item);
            }

        }

        public Compromisso Compromisso
        {
            set
            {
                txtID.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                dtpData.Value = value.data;
                dtpInicio.Value = value.horaDeInicio;
                dtpTermino.Value = value.horaDeTermino;

                if (value.ehPresencial)
                {
                    txtPresencial.Text = value.local;
                    txtRemoto.Text = string.Empty;
                }
                else
                {
                    txtPresencial.Text = string.Empty;
                    txtRemoto.Text = value.local;
                }
            }
            get
            {
                return compromisso;
            }
        }

        private void rbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            compromisso.ehPresencial = false;
        }

        private void rbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            compromisso.ehPresencial = true;
        }
        private void MarcarContato_CheckedChanged(object sender, EventArgs e)
        {
            compromisso.vaiTerAlguem = true;

        }
        private void DropDeContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            repositorioContato.SelecionarTodos();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (compromisso.vaiTerAlguem = false)
            {
                if (compromisso.ehPresencial = true)
                {
                    string assunto = txtAssunto.Text;
                    DateTime data = dtpData.Value;
                    DateTime horaDeInicio = dtpInicio.Value;
                    DateTime horaDeTermino = dtpTermino.Value;
                    Contato contato = null;

                    string local = txtPresencial.Text;
                }
                else if (compromisso.ehPresencial = false)
                {
                    string assunto = txtAssunto.Text;
                    DateTime data = dtpData.Value;
                    DateTime horaDeInicio = dtpInicio.Value;
                    DateTime horaDeTermino = dtpTermino.Value;
                    Contato contato = null;
                    string local = txtRemoto.Text;
                }
            }
            else if (compromisso.vaiTerAlguem = false)
            {
                if (compromisso.ehPresencial = true)
                {
                    string assunto = txtAssunto.Text;
                    DateTime data = dtpData.Value;
                    DateTime horaDeInicio = dtpInicio.Value;
                    DateTime horaDeTermino = dtpTermino.Value;
                    string local = txtPresencial.Text;
                    if (DropDeContatos.SelectedItem is Contato contatoSelecionado)
                    {
                        contato = contatoSelecionado;
                    }
                }
                else if (compromisso.ehPresencial = false)
                {
                    string assunto = txtAssunto.Text;
                    DateTime data = dtpData.Value;
                    DateTime horaDeInicio = dtpInicio.Value;
                    DateTime horaDeTermino = dtpTermino.Value;
                    string local = txtPresencial.Text;
                    if (DropDeContatos.SelectedItem is Contato contatoSelecionado)
                    {
                        contato = contatoSelecionado;
                    }
                }
            }
           


        }
    }
}

