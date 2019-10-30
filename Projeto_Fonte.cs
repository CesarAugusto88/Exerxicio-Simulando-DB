using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Projeto_Fonte
    {
        public string Numero { get; set; }
        public string Nome { get; set; }

        public Projeto_Fonte(string numero, string nome)
        {
            this.Numero = numero;
            this.Nome = nome;
            
        }
        // Construtor sobre carga
        public Projeto_Fonte()
        {

        }

    }
}
