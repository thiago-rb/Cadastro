using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class SistemaCadastro
    {
        private List<Registro> registros = new List<Registro>();

        public void CadastrarRegistro(string nome, string idade, string cpf)
        {
            Registro registro = new Registro(nome, idade, cpf);
            registros.Add(registro);
           
        }

        public void ListarRegistros()
        {
            Console.WriteLine();
            Console.WriteLine("Registros cadastrados: ");
            Console.WriteLine();
            foreach (Registro registro in registros)
            {
                Console.WriteLine(registro);
            }
        }

        public void RemoverRegistro(string nome, string idade, string cpf)
        {
            Console.WriteLine("Registros removidos: ");
            Registro registro = new Registro(nome, idade, cpf);
            registros.Remove(registro);
        }
    }
}
