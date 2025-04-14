using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    // Método que será ejecutado por los hilos
    static void Proceso(object id)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Hilo {id}: Iteración {i}");
            Thread.Sleep(1000); // Simula un proceso que toma tiempo
        }
    }
    static void Main(String[] args)
    {
        Console.WriteLine("Inicio del programa...");
        Console.WriteLine("Flujo unicol..");
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        Proceso(1);
        Proceso(2);
        Proceso(3);
        stopwatch1.Stop();
        Console.WriteLine("Tiempo de ejecución: {0} ms", stopwatch1.ElapsedMilliseconds);
        Thread hilo1 = new Thread(Proceso);
        Thread hilo2 = new Thread(Proceso);
        Thread hilo3 = new Thread(Proceso);


        Stopwatch stopwatch2 = Stopwatch.StartNew();
        hilo1.Start(1);
        hilo2.Start(2);
        hilo3.Start(3);

        hilo1.Join();
        hilo2.Join();
        hilo3.Join();

        stopwatch2.Stop();
        Console.WriteLine("Tiempo de ejecución: {0} ms", stopwatch2.ElapsedMilliseconds);
        Console.WriteLine("Fin del programa...");
    }
}