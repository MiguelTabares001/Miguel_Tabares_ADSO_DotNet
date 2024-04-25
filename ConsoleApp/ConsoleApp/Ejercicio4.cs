/*
----------------Ejercicio 4---------------------- 

 - Realizar un programa que permita llenar un array de n numeros reales. Imprimir el array. 
Ejemplo:
3, 2.45, 1, -3.5
R/-3.5, 1, 2.45, 3
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] arreglo = new double[n];

        // Llenar el arreglo con números reales ingresados por el usuario
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el elemento {i + 1}: ");
            arreglo[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nArreglo original:");

        // Imprimir el arreglo en desorden
        ImprimirArreglo(arreglo);

        // Ordenar el arreglo ascendente sin usar funciones del lenguaje
        OrdenarArreglo(arreglo);

        Console.WriteLine("\nArreglo ordenado:");

        // Imprimir el arreglo ordenado
        ImprimirArreglo(arreglo);
    }

    static void OrdenarArreglo(double[] arreglo)
    {
        int n = arreglo.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    // Intercambiar elementos
                    double temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }
    }

    static void ImprimirArreglo(double[] arreglo)
    {
        foreach (double num in arreglo)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}

