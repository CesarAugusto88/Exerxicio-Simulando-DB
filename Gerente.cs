using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Gerente:Pessoa
    {
        
        public Gerente(string codigo, string nome, string numDepto) : base(codigo, nome, numDepto)
        {            

        }
        // método para exibir informações
        public void exibe_info()
        {
            Console.WriteLine("----Gerente----");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Número do departamento: " + NumDepto);
            Console.WriteLine();
          

        }
        // método para alterar informações
        public void Alt_info()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Número do departamento: ");
            NumDepto = Console.ReadLine();

        }


    }
}
