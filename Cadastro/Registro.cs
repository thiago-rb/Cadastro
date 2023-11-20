using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    internal class Registro
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Cpf { get; set; }

        public Registro(string nome, string idade, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, CPF: {Cpf}";
        }
    }
}
