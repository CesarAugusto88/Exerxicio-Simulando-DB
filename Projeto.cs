using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Projeto:Projeto_Fonte
    {
        public string Descricao { get; set; }
        public string NumDepto { get; set; }
        
        public Projeto(string numero, string nome, string descricao, string numDepto) : base(numero, nome)
        {
            this.Descricao = descricao;
            this.NumDepto = numDepto;
            
        }
        // método para exibir informações
        public void exibe_info()
        {
            Console.WriteLine("----Projeto----");
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Descrição: " + Descricao);
            Console.WriteLine("Número do departamento: " + NumDepto);
            Console.WriteLine();


        }
        // método para alterar informações
        public void Alt_info()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Descrição: ");
            Descricao = Console.ReadLine();
            Console.Write("Número do departamento: ");
            NumDepto = Console.ReadLine();

        }
    }
}
