using System;

namespace exercicio_graus_cf
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, Fahrenheit;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("-------Tranformação de Fahrenheit para Celsius-------");
                Console.WriteLine(); 

                Console.Write("Digite quantos Graus tem que ser convertidos (EM FAHRENHEIT): ");
                Fahrenheit = Convert.ToDouble(Console.ReadLine());
             Console.ResetColor();



                    Celsius = (Fahrenheit - 32) / 1.8;

                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Resultado: {Celsius:N3}°c"); // Formula da Transformção de Fahrenheit em Celsius
                Console.ResetColor();
                
        }
    }
}
