using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensioni = { 50, 100, 500, 1000, 5000, 10000, 20000, 30000,40000,50000 };
            using (StreamWriter w = new StreamWriter(" stat.csv ", false, Encoding.UTF8))
            {

                w.WriteLine("Algoritmo,Dimensione,Tempo");
                foreach (int dim in dimensioni)
                {
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                        array[i] = r.Next(0, 50000);
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    Bubblesort.Sort(array);
                    s.Stop();
                    long tempotrascorso = s.ElapsedMilliseconds;
                    Console.WriteLine($"Bubblesort{dim};{tempotrascorso}");
                    w.WriteLine($"Bubblesort{dim};{tempotrascorso}");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = r.Next(0, 50000);
                    }
                    s.Start();
                    Bubblesort.Sort(array);
                    s.Stop();
                    tempotrascorso = s.ElapsedMilliseconds;
                    Console.WriteLine($"Bubblesort{dim};{tempotrascorso}");
                    w.WriteLine($"Bubblesort{dim};{tempotrascorso}"); for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = r.Next(0, 50000);
                    }
                    s.Start();
                    Bubblesort.Sort(array);
                    s.Stop();
                    tempotrascorso = s.ElapsedMilliseconds;
                    Console.WriteLine($"Bubblesort{dim};{tempotrascorso}");
                    w.WriteLine($"Bubblesort{dim};{tempotrascorso}"); for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = r.Next(0, 50000);
                    }
                    s.Start();
                    Bubblesort.Sort(array);
                    s.Stop();
                    tempotrascorso = s.ElapsedMilliseconds;
                    Console.WriteLine($"Bubblesort{dim};{tempotrascorso}");
                    w.WriteLine($"Bubblesort{dim};{tempotrascorso}"); 
                }
                w.Flush();
                Console.WriteLine("finito");
            }
            Console.ReadLine();
        }
    } 
}
