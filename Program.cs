using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            boasVindas();

            do
            {
                comanda("--> Defina o limite: ");
                laco();

                Console.WriteLine();
                Console.WriteLine("Continuar?? ('Sim' para Sim / 'Qualquer tecla' para Não)");
                a = Console.ReadLine()  .ToUpper();
                Console.WriteLine();

            } while (a == "SIM");
        }

        static void boasVindas()
        {
            DateTime agora = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine($"Olá!!                    {agora}");
            Console.WriteLine();

            Console.WriteLine(" *** Exercício Fibonacci ***");
            Console.WriteLine("- Recepção de um número inteiro N. Exibição dos N primeiros números da sequência de Fibonacci.");
            Console.WriteLine();
        }

        static void comanda(string recepcao)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(recepcao);
            Console.ResetColor();
        }

        static void laco()
        {
            int limite;
            int limite2 = 1;
            int resul = 0;
            int resul1 = 1;
            int resul3;

            do
            {
                limite = Convert.ToInt32(Console.ReadLine());

                if (limite < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Atenção!! Limite inválido.");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("--> Defina um novo limite...: ");
                    Console.ResetColor();
                }

            } while (limite < 1);

            while (limite2 <= limite)
            {

                resul3 = resul1 + resul;

                Console.Write($"- {resul3} ");

                resul = resul1;
                resul1 = resul3;


                limite2++;
            }

            Console.WriteLine();
        }
    }
}
