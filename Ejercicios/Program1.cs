using System;

namespace ArrayEjercicio1;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Ingrese el tamaño del arreglo (mínimo 5): ");
        int tamaño = Convert.ToInt32(Console.ReadLine());

        if (tamaño < 5)
        {
            Console.WriteLine("El tamaño debe ser al menos 5.");
            return;
        }


        int[] array = new int[tamaño];


        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Ingrese el valor para la posición {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Valores del arreglo:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Posición {i + 1}: {array[i]}");
        }
    }
}
