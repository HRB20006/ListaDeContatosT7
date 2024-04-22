﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT7
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {
            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }
        public Contato()
        {
            Nome = "Jailson";
            Sobrenome = "Mendes";
            Telefone = "(81) 69969-2469";
        }
        public Contato(string nome, string sobrenome, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}", Telefone.Substring(0, 2), Telefone.Substring(2,5), Telefone.Substring(7,4));
            return saida;
        }
    }
}

