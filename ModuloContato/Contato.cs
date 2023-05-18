using E_Agenda.Compartilhado;

namespace E_Agenda.ModuloContato
{
    public class Contato : EntidadeBase 
    {
        public int id;
        public string nome;
        public string cargo;
        public string telefone;
        public string email;
        public string empresa;

        public Contato(string nome, string cargo, string telefone, string email, string empresa)
        {
            
            this.nome = nome;
            this.cargo = cargo;
            this.email = email;
            this.telefone = telefone;
            this.empresa = empresa;
        }

        public override string ToString()
        {
            return $"ID: {id}, {nome}, Empresa: {empresa}";
        }
    }
}
