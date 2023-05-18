﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Agenda.ModuloContato
{
    public class RepositorioContato
    {
        List<Contato> contatos = new List<Contato>();

        private static int contador;

        public void Inserir(Contato contato)
        {
            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }
        public List<Contato> SelecionarTodos() 
        {
            return contatos;
        
        }

        public void Editar(Contato contato)
        {
            Contato contatoSelecionado = SelecionarPorId(contato.id);
            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.email = contato.email;   
            contatoSelecionado.empresa = contato.empresa;
            contatoSelecionado.cargo = contato.cargo;
        }

        private Contato SelecionarPorId(int id)
        {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        public void Excluir(Contato contato)
        {
            contatos.Remove(contato);
        }
    }
}
