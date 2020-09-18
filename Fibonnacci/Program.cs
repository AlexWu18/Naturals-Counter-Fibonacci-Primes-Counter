using System;

namespace Fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Escriba el digito para la cantidad de sucesion: ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());

                    double[] Fib = new double[2];
                    Fib[0] = 1;
                    Fib[1] = 1;
                    int Num = 1;
                    Console.WriteLine("La sucesion Fibonacci es: ");
                    while (Num <= Cantidad)
                    {
                        Console.WriteLine(Fib[0]);
                        double Temp = Fib[1] + Fib[0];
                        Fib[0] = Fib[1];
                        Fib[1] = Temp;

                        Num++;
                    }
                    Console.ReadKey();
        }
    }
}
