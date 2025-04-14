using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static string[] resultados = new string[12]; // Arreglo para almacenar los resultados de las tablas de multiplicar 

    static void CalcularTabla(object num)
    {
        int n = (int)num;
        Stopwatch stopwatch = Stopwatch.StartNew();
        string resultado = $"Tabla del {n}:\n";

        for (int i = 1; i <= 12; i++)
        {
            resultado += $"{n} x {i} = {n * i}\n";
            Thread.Sleep(500); //simula un una espera en el proceso 
        }

        stopwatch.Stop();
        resultado += $"Tiempo de ejecución: {stopwatch.ElapsedMilliseconds} ms\n";


        resultados[n - 1] = resultado;
    }

    static void Main()
    {
        Thread[] hilos = new Thread[12];

        // Crear e iniciar los hilos
        for (int i = 1; i <= 12; i++)
        {
            hilos[i - 1] = new Thread(CalcularTabla);
            hilos[i - 1].Start(i);
        }

        // Esperar a que todos los hilos terminen
        foreach (Thread hilo in hilos)
        {
            hilo.Join();
        }

        Console.WriteLine("\nFinalizacion de todos los hilos:\n");

        // Imprimir las tablas en orden con un retraso de 1 segundo entre cad


        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(resultados[i]);
            Thread.Sleep(1000); // Pausa de 1 segundo entre cada impresión
        }
    }
}