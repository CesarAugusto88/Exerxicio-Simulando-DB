using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria objetos classe Departamento, exibe informações e altera
            // 1ª instância
            Departamento departamento1 = new Departamento("10", "Desenvolvimento", "Centro");
            departamento1.exibe_info();
            Console.WriteLine("Deseja alterar dados do departamento? [S]im/[N]ão");
            string resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                departamento1.Alt_info();
                departamento1.exibe_info();
            }
            // 2ª instância
            Departamento departamento2 = new Departamento("03", "Engenharia", "Urbano");
            departamento2.exibe_info();
            Console.WriteLine("Deseja alterar dados do Departamento? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                departamento2.Alt_info();
                departamento2.exibe_info();
            }

            // Cria objetos classe Departamento, exibe informações e altera
            // 1ª instância
            // As chaves estrangeiras poderiam ser verificadas no código ou
            // feitas no banco de dados
            Projeto projeto1 = new Projeto("0100", "Projeto WEB-tree", "Aplicação web desenvolvida com wordpress", "10");
            projeto1.exibe_info();
            Console.WriteLine("Deseja alterar dados do departamento? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                projeto1.Alt_info();
                projeto1.exibe_info();
            }
            // 2ª instância
            Projeto projeto2 = new Projeto("0101", "Projeto How-visio", "Alterações no software ABCD", "03");
            projeto2.exibe_info();
            Console.WriteLine("Deseja alterar dados do Departamento? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                projeto2.Alt_info();
                projeto2.exibe_info();
            }
            // Cria objetos classe Gerente e exibe informações
            // 1ª instância
            Gerente gerente1 = new Gerente("001", "Cesar Augusto", "10");
            gerente1.exibe_info();
            Console.WriteLine("Deseja alterar dados do Gerente? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                gerente1.Alt_info();
                gerente1.exibe_info();
            }
            // 2ª instância
            Gerente gerente2 = new Gerente("002", "Mario Andrade", "03");
            gerente2.exibe_info();
            Console.WriteLine("Deseja alterar dados do Gerente? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                gerente2.Alt_info();
                gerente2.exibe_info();
            }

            // Cria objetos classe Empregado, exibe informações e altera
            // 1ª instância
            Empregado empregado1 = new Empregado("00010", "Pedro Gonçalves", "10", "Rua ACD", "2222-2222", "12-01-2019", 1600);
            empregado1.exibe_info();
            Console.WriteLine("Deseja alterar dados do Empregado? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                empregado1.Alt_info();
                empregado1.exibe_info();
            }
            // 2ª instância
            Empregado empregado2 = new Empregado("00012", "Jefferson Matias", "03", "Rua JK", "2222-3333", "30-01-2014", 3560.86);
            empregado2.exibe_info();
            Console.WriteLine("Deseja alterar dados do Empregado? [S]im/[N]ão");
            resp = Console.ReadLine();
            if (resp.ToUpper() == "S")
            {
                empregado2.Alt_info();
                empregado2.exibe_info();
            }

            Console.ReadKey();

        }
    }
}
