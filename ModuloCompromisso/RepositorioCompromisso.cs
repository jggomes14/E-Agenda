using E_Agenda.ModuloContato;

namespace E_Agenda.ModuloCompromisso
{
    public class RepositorioCompromisso
    {
        List<Compromisso> compromissos = new List<Compromisso>();

        private static int contador;

        public void Inserir(Compromisso compromisso)
        {
            contador++;
            compromisso.id = contador;
            compromissos.Add(compromisso);
        }
        public List<Compromisso> SelecionarTodos()
        {
            return compromissos;

        }

        public void Editar(Compromisso compromisso)
        {
            Compromisso contatoSelecionado = SelecionarPorId(compromisso.id);
            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.cargo = contato.cargo;
        }

        private Contato SelecionarPorId(int id)
        {
            return compromissos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato contato)
        {
            compromissos.Remove(contato);
        }
    }
}
