//----------------Ejercicio 2--------------
//- En c# sin usar formularios, crear un programa que determine si una frase o palabra es palindroma. Contabilizar e imprimir numero de vocales, elimina los espacios a la hora de comprar si es palindromo o no, la frase o palabra o numero sea dada por el usuario en la consola. Ejemplo: ala 7007

using System;

<<<<<<< HEAD
public class Palindromo
{
    public static void Main(string[] args)
    {

        Console.Write("Ingrese una frase para verificar si es un palindromo: ");
        string input = Console.ReadLine();

        // quito espacios -> con esto se arreglo
        string cleanInput = input.Replace(" ", "").ToLower();

=======
public class Program
{
    public static void Main(string[] args)
    {
       
        Console.Write("Ingrese una frase para verificar si es un palindromo: ");
        string input = Console.ReadLine();

        // quito espacios -> con esto se arreglo
        string cleanInput = input.Replace(" ", "").ToLower();

>>>>>>> 66dd16b99279caf594595362498863f9db404774
        // Reverso de la cadena
        char[] charArray = cleanInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        // Comprobacion si la cadena original es igual a su reverso
        bool isPalindrome = cleanInput.Equals(reversedInput);

        if (isPalindrome)
        {
            Console.WriteLine("La frase ingresada es un palindromo.");
        }
        else
        {
            Console.WriteLine("La frase ingresada no es un palindromo.");
        }
    }
}

