using System;

class Program
{
    static void Main(string[] args)
    {
        // Definicion de variables para el máximo, mínimo, cantidad de negativos y cantidad de positivos
        int maximo = int.MinValue;
        int minimo = int.MaxValue;
        int cantidadNegativos = 0;
        int cantidadPositivos = 0;


        // Pido al usuario que ingrese la cantidad de números que desea procesar
        Console.Write("Ingrese la cantidad de números a evaluar: ");
        int cantidadNumeros = int.Parse(Console.ReadLine());

        // Pido al usuario que ingrese los números y realizamos los cálculos
        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            // Clculo el máximo y el mínimo
            if (numero > maximo)
            {
                maximo = numero;
            }
            if (numero < minimo)
            {
                minimo = numero;
            }

            // Recuento de negativos y los positivos
            if (numero < 0)
            {
                cantidadNegativos++;
            }
            else if (numero > 0)
            {
                cantidadPositivos++;
            }
        }

       
        Console.WriteLine($"El máximo valor ingresado es: {maximo}");
        Console.WriteLine($"El mínimo valor ingresado es: {minimo}");
        Console.WriteLine($"Cantidad de números negativos: {cantidadNegativos}");
        Console.WriteLine($"Cantidad de números positivos: {cantidadPositivos}");

        Console.ReadKey();
    }
}