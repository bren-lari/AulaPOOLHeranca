using System;
using POOL___Herança.Classes;

namespace POOL___Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            PessoaFisica pessoa = new PessoaFisica();
            Console. Write("-> Insira seu CPF: ");
            pessoa.cpf = Console.ReadLine();
            pessoa.nome = "Brenda";
            Console.WriteLine(pessoa.DarBoasVindas(pessoa.nome));
            Console.WriteLine(pessoa.ValidarCPF(pessoa.cpf));


            PessoaJuridica pessoa2 = new PessoaJuridica();
            Console. Write("\n-> Insira seu CNPJ: ");
            pessoa2.cnpj = Console.ReadLine();
            pessoa2.nome = "Brenda";
            Console.WriteLine(pessoa2.ValidarCNPJ(pessoa2.cnpj));
            
        }
    }
}
