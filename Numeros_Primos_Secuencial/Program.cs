using System;
using System.Diagnostics;

class Program
{
    static int sumaTotal = 0;

    static void CalcularPrimos(int inicio, int fin)
    {
        int suma = 0;
        for (int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
            {
                suma += i;
            }
        }
        sumaTotal += suma;
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número límite:");
        int N = int.Parse(Console.ReadLine());

        Stopwatch stopwatch = Stopwatch.StartNew();

        // Llamada secuencial: procesa todos los números en un solo hilo
        CalcularPrimos(1, N);

        stopwatch.Stop();
        Console.WriteLine($"Suma total de números primos hasta {N}: {sumaTotal}");
        Console.WriteLine($"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms");
    }
}