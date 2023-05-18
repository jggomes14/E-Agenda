using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Agenda.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;
        public TelaContatoForm()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            set
            {
                txtID.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtCargo.Text = value.cargo;
                txtEmail.Text = value.email;
                txtEmpresa.Text = value.empresa;
                txtTelefone.Text = value.telefone;
            }
            get
            {
                return contato;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;


            contato = new Contato(nome, cargo, telefone, email, empresa);

            if (txtID.Text != "0")
                contato.id = Convert.ToInt32(txtID.Text);

        }
    }
}
