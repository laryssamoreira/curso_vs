using System;
using System.Globalization;

namespace PrimeirosExercicios___Secao_4 {
    class Program {
        static void Main(string[] args) {
            //EXERCICIO 1
            /*Dados dado1 = new Dados();
            Dados dado2 = new Dados();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            dado1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            dado1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            dado2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            dado2.Idade = int.Parse(Console.ReadLine());

            if(dado1.Idade > dado2.Idade) {
                Console.WriteLine("Pessoa mais velha:" + dado1.Nome);
            }
            else if (dado2.Idade > dado1.Idade) {
                Console.WriteLine("Pessoa mais velha:" + dado2.Nome);
            }
            else {
                Console.WriteLine("Eles possuem a mesma idade.");
            }
            */

            //EXERCÍCIO 2
            /*
             */
            Dados dado1 = new Dados();
            Dados dado2 = new Dados();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            dado1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            dado1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            dado2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            dado2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (dado1.Salario + dado2.Salario) / 2;

            Console.WriteLine("Salario medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
