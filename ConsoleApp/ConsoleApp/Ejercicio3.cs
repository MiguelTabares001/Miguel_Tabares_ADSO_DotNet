using System;

//----------Ejercicio 3---------------------- -

/*-Realice un programa en c# que lea unas observaciones y reemplace los caracteres @ | & # por X. 
Elimine los caracteres ? ¿. 
Inserte al comienzo la palabra init. 
Inserte al final la palabra end. 
Imprimir todo en mayusculas.
*/

using System;

public class HelloWorld
{
    public void Main(string[] args)
    {
        // Leer las cosas insertadas por el usuario
        Console.Write("Inserte su observacion: ");
        string input = Console.ReadLine();

        // reemplazo @ | & # con una X
        input = input.Replace("@", "X");
        input = input.Replace("|", "X");
        input = input.Replace("&", "X");
        input = input.Replace("#", "X");

        // eliminacion signos ? ¿
        input = input.Replace("?", "");
        input = input.Replace("¿", "");

        // Inserto init al principio
        input = "init " + input;

        // Insert end al final
        input = input + " end";

        // Convert to uppercase
        input = input.ToUpper();

        // Resultados
        Console.WriteLine("REsultados:");
        Console.WriteLine(input);
    }
}

