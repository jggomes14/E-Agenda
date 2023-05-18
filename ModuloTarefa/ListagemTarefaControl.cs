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

namespace E_Agenda.ModuloTarefa
{
    public partial class ListagemTarefaControl : UserControl
    { 
        List<Tarefa> tarefas = new List<Tarefa>();
        public ListagemTarefaControl()
        {
            InitializeComponent();
            tarefas.Add(new Tarefa(1, "Lavar Roupa", "Alta"));
            tarefas.Add(new Tarefa(2, "Lavar Louça", "Média"));

            foreach (Tarefa item in tarefas)
            {
                listTarefas.Items.Add(item);

            }

        }
    }
}
