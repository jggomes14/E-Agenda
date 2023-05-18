namespace E_Agenda.ModuloTarefa
{
    public partial class ListagemTarefaControl
    {
        public class Tarefa
        {
            public int id;
            public string tarefa;
            public string prioridade;

            public Tarefa(int id, string tarefa, string prioridade)
            {
                this.id = id;
                this.tarefa = tarefa;
                this.prioridade = prioridade;
            }

            public override string ToString()
            {
                return $"ID: {id}, {tarefa}, Empresa: {prioridade}";
            }
        }
    }
}
