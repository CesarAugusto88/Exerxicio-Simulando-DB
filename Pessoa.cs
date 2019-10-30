using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Pessoa
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string NumDepto { get; set; }
        
        // construtor
        public Pessoa(string codigo, string nome, string numDepto)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.NumDepto = numDepto;

        }

        // Construtor de sobre carga
        // Para os que herdam possam ter sobre carga também
        public Pessoa()
        {
            

        }


    }
}
