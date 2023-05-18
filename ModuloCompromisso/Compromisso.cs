using E_Agenda.Compartilhado;
using E_Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.ModuloCompromisso
{
    public class Compromisso : EntidadeBase
    {
        public int id;
        public string Assunto;
        public string Data;
        public string HoraDeInicio;
        public string HoraDeTermino;
        public string empresa;
        public Contato contato;

    }

}
