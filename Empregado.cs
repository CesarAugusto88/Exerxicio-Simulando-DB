using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Empregado:Pessoa
    {
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Data_Admissao { get; set; }
        public double Salario { get; set; }
        public Empregado(string codigo, string nome, string numDepto, string endereco, string telefone, string dataAdmissao, double salario) : base(codigo, nome, numDepto)
        {
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Data_Admissao = dataAdmissao;
            this.Salario = salario;

        }
        // Método para exibir informações
        public void exibe_info()
        {
            Console.WriteLine("----Empregado----");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Número do departamento: " + NumDepto);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Data de Admissão: " + Data_Admissao);
            Console.WriteLine("Salário: R$" + Salario);
            Console.WriteLine();

        }
        // Método para alterar informações. Poderia colocar na classe Pessoa
        // Ou criar uma classe Informações
        public void Alt_info()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Número do departamento: ");
            NumDepto = Console.ReadLine();
            Console.Write("Endereço: ");
            Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            Telefone = Console.ReadLine();
            Console.Write("Salário: R$");
            Salario = double.Parse(Console.ReadLine());


        }


    }
}
