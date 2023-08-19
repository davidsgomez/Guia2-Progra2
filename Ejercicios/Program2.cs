using System;

namespace ArrayEjercicio2;

class Program
{
    static void Main()
    {

        string[] nombreCompleto = { "David", "Sibrian" };

        foreach (string valor in nombreCompleto)
        {
            Console.WriteLine(valor);
        }

        int longitudArreglo = nombreCompleto.Length;

        Console.WriteLine("Tamaño del arreglo: " + longitudArreglo);
        foreach (string valor in nombreCompleto)
        {
            Console.WriteLine("Valor: " + valor);
        }
    }
}