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

namespace E_Agenda.ModuloCompromisso
{
    public partial class ListagemCompromissoControl : UserControl
    {
        List<Compromisso> compromissos = new List<Compromisso>();
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            listCompromissos.Items.Clear();
            foreach (Compromisso item in compromissos)
            {
                listCompromissos.Items.Add(item);

            }
        }
        public Contato ObterCompromissoSelecionado()
        {
            return (Contato)listCompromissos.SelectedItem;
        }
    }
}
