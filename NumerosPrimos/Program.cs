using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
                int Z = 0;
                int X = 0;

                    Console.WriteLine("Digite un numero: ");
                    Z = int.Parse(Console.ReadLine());

                    for (int i = 1; i < Z; i++)
                    {
                        if (Z % i == 0)
                        {
                            X = X + 1;
                        }
                    }
                    if (X >= 2)
                    {
                        Console.WriteLine(" {0} No es un numero primo. ", Z);
                    }
                    else
                    {
                        Console.WriteLine(" {0} Es un numero primo. ", Z);
                    }

                    Console.ReadKey();
        }
    }
}
