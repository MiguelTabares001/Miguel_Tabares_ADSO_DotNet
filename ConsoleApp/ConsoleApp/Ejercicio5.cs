/* 
 ----------------Ejercicio 5---------------------- 

Realice Un programa usando c# que te pida tu nombre y 
lo muestre en una pantalla separando cada letra de la siguiente con un espacio.
Ejemplo: si tu nombre es "Maria" debería aparecer en pantalla "M a r i a".´
*/

using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, introduce tu nombre:");
        string nombre = Console.ReadLine();

        // Aqui se itera sobre cada letra del nombre y se imprime con el espacio
        foreach (char letra in nombre)
        {
            Console.Write(letra + " ");
        }

        Console.WriteLine(); // Salto de línea al final
    }
}
