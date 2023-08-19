using System;

namespace ArregloEjercicio5;

class Program
{
    static void Main()
    {
        int[] array = { 4, 10, 45, -67, -7, 25, 89, 64 };

        Console.WriteLine("Arreglo en orden original:");
        PrintArray(array);

        Array.Reverse(array);
        Console.WriteLine("\nArreglo después de Reverse:");
        PrintArray(array);

        Array.Sort(array);
        Console.WriteLine("\nArreglo después de Sort:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}