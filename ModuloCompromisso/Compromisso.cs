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
        public string assunto;
        public DateTime data;
        public DateTime horaDeInicio;
        public DateTime horaDeTermino;
        public Contato contato;
        public bool vaiTerAlguem;
        public bool ehPresencial;
        public string local;

        public Compromisso(string assunto, DateTime data, DateTime horaDeInicio, DateTime horaDeTermino, bool ehPresencial, bool vaiTerAlguem, string local, Contato contato)
        {

            this.assunto = assunto;
            this.data = data;
            this.horaDeInicio = horaDeInicio;
            this.horaDeTermino = horaDeTermino;
            this.contato = contato;
            this.ehPresencial = ehPresencial;
        }

    }

}
