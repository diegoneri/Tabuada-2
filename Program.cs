using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [console: Tabuada] Receba um número. Exiba sua tabuada.
            Ex.:
            Tabuada do número: 7

            7 x 0 = 0
            7 x 1 = 7
            7 x 2 = 14
            7 x 3 = 21
            7 x 4 = 28
            7 x 5 = 35
            7 x 6 = 42
            7 x 7 = 49
            7 x 8 = 56
            7 x 9 = 63
            7 x 10 = 70
            */

            bool fim = false;

            int numero;

            int valorinicial = 0;

            while (!fim)
            
            // optei or colocar o int de 0 como falor inicial parafacilitar o entendimento, pois zero é o número ultilizado na primeira multiplicação
            {

            Console.WriteLine("Você precisa da tabuada de qual número?.");

            bool numerobool = Int32.TryParse(Console.ReadLine(), out numero);

            if (!numerobool)

            {

                Console.WriteLine("Valor inválido.");

                Console.WriteLine("Tente novamente, digitando outro valor.");

                Console.ReadKey();

            }

            else

            {

                while (valorinicial < 11)

                // quando o valor digitado pelo usuário for menor que 11, o programa realiza sua função

                {

                    int resultadofinal = numero * valorinicial;

                    Console.WriteLine($"{numero} x {valorinicial} = {resultadofinal}");
                    
                    valorinicial = valorinicial + 1;
                    
                    // comando de ultilizado pelo professor ermogenes para que a cada multiplicação aumente em 1
                }

                fim = true;

            }

            }

            Console.WriteLine("Esse foi o meu programa,aperte uma tecla para finalizar.");

            Console.ReadKey();
        }
    }
}
