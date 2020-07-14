using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: Fibonacci] Receba um número inteiro N. Exiba os N primeiros números da sequência de Fibonacci.
            Nesta sequência, os dois primeiros números são 0 e 1. Os próximos números são a soma dos dois números anteriores.
            0
            1
            0 + 1 = 1
            1 + 1 = 2
            1 + 2 = 3
            2 + 3 = 5
            3 + 5 = 8
            ...
            Ex.:
            Sequência de Fibonacci
            Quantos termos (>=2)? 21
            0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765
            */

            int n;
            int n1 = 0;
            int n2 = 1;
            int final = 0;

            bool positivo;

            // número aprovado pelo sistema

            Console.WriteLine("Digite um número...");

            positivo = Int32.TryParse(Console.ReadLine(), out n);

            if (n < 2)

            {

                Console.WriteLine("Número inválido.");

                Console.WriteLine("Aperte qualquer tecla.");

                Console.ReadKey();

                Environment.Exit(-1);

                // omando para fechar o programa

            }

            for (int contador = 0; contador < n; contador++)

            // pra simplificar, como o usuário digitará apenas um número irei usar o tipo de laço for

            {
                Console.WriteLine(final);

                final = n1 + n2;
                
                n2 = n1;

                n1 = final;

            }



            Console.WriteLine("Esse foi o meu programa, aperte qualquer tecla para encerrar.");

            Console.ReadKey();



        }
    }
}
