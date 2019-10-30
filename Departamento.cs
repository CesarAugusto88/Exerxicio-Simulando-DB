using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Departamento:Projeto_Fonte
    {
        public string Localizacao { get; set; }

        public Departamento(string numero, string nome, string localizacao) : base(numero, nome)
        {
            this.Localizacao = localizacao;

        }
        // Método para exibir informações
        public void exibe_info()
        {
            Console.WriteLine("----Departamento----");
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Localização: " + Localizacao);
            Console.WriteLine();


        }
        // Método para alterar informações
        public void Alt_info()
        {
            Console.Write("Número: ");
            Numero = Console.ReadLine();
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Localização: ");
            Localizacao = Console.ReadLine();
            

        }

    }
}
