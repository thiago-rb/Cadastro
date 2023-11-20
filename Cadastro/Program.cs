using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaCadastro sistema = new SistemaCadastro();

            Console.WriteLine("BEM-VINDO AO SISTEMA SOCIAL DE CADASTRO");
            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Opções do sistema");
                Console.WriteLine("1. Cadastrar");
                Console.WriteLine("2. Listar os cadastros");
                Console.WriteLine("3. Fechar");
                Console.Write("Digite o numero da opção desejada: ");
                string opcao = Console.ReadLine();
                

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Insira o nome do usuário: ");
                        string nome = Console.ReadLine();

                        Console.Write("Insira a idade do usuário: ");
                        string idade = Console.ReadLine();

                        Console.Write("Insira o CPF do usuário: ");
                        string cpf = Console.ReadLine();

                        Console.WriteLine("Cadastro realizado!");
                        Console.WriteLine();

                        sistema.CadastrarRegistro(nome, idade, cpf);
                        break;

                    case "2":
                        sistema.ListarRegistros();
                    break;

                    case "3":
                        Console.WriteLine("Saindo do programa...");
                    return;

                    case "4":
                        sistema.RemoverRegistro();
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                    break;


                }
               
            }

           
        }
    }
}
