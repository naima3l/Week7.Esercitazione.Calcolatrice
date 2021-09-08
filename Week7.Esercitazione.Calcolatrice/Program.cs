using System;
using Week7.Esercitazione.Calcolatrice.Core;

namespace Week7.Esercitazione.Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            int choice;
            double? result;
            Calculator calculator = new Calculator();
            do
            {
                Console.WriteLine("Ecco la tua calcolatrice!");
                Console.WriteLine("Scegli l'operazione : \n1. Somma\n2. Divisione\n3. Sottrazione\n4. Moltiplicazione\n5. Verifica Maggiore\n0. Esci");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4)
                {
                    Console.WriteLine("Scelta non valida! Riprova.");
                }

                

                switch (choice)
                {
                    case 1:
                        result = calculator.Sum(Numbers());
                        Console.WriteLine($"Il risultato della somma è : {result}");
                        break;
                    case 2:
                        result = calculator.Div(Numbers());
                        if(result == null)
                        {
                            Console.WriteLine($"Stai cercando di dividere qualcosa per 0");
                        }
                        else Console.WriteLine($"Il risultato della divisione è : {result}");
                        break;
                    case 3:
                        result=calculator.Subtraction(Numbers());
                        Console.WriteLine($"Il risultato della sottrazione è : {result}");
                        break;
                    case 4:
                        result = calculator.Multiiplication(Numbers());
                        Console.WriteLine($"Il risultato della moltiplicazione è : {result}");
                        break;
                    case 0:
                        check = false;
                        break;
                }
            } while (check);
        }

        private static double[] Numbers()
        {
            double[] num = new double[2];
            double n1, n2;

            Console.WriteLine("Inserisci primo numero");
            while(!double.TryParse(Console.ReadLine(),out n1))
            {
                Console.WriteLine("Riprova");
            }

            Console.WriteLine("Inserisci secondo numero");
            while (!double.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Riprova");
            }
            num[0] = n1;
            num[1] = n2;

            return num;

        }

        private static int[] IntNumbers()
        {
            int[] num = new int[2];
            int n1, n2;

            Console.WriteLine("Inserisci primo numero");
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Riprova");
            }

            Console.WriteLine("Inserisci secondo numero");
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Riprova");
            }
            num[0] = n1;
            num[1] = n2;

            return num;
        }
    }
}
