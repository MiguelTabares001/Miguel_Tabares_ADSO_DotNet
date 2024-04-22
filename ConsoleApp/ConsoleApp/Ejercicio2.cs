using System;

//----------------Ejercicio 2--------------
//- En c# sin usar formularios, crear un programa que determine si una frase o palabra es palindroma. Contabilizar e imprimir numero de vocales, elimina los espacios a la hora de comprar si es palindromo o no, la frase o palabra o numero sea dada por el usuario en la consola. Ejemplo: ala 7007

using System;

public class PalindromeChecker
{
    public void Main(string[] args)
    {
        Console.Write("Enter a word or phrase: ");
        string input = Console.ReadLine().ToLower(); // convertio el coso de entrada en minuscula

        // Quito los espacios para que funcione !!
        input = input.Replace(" ", "");

        // Conteo de vocales
        int vowelCount = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++;
            }
        }

        // Verifico si es palindromo
        bool isPalindrome = true;
        for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
        {
            if (input[i] != input[j])
            {
                isPalindrome = false;
                break;
            }
        }

        // SAlida tactica
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine(isPalindrome ? input + " is a palindrome" : input + " is not a palindrome");
    }
}
