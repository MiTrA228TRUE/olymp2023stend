using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string[] xuy = new string[] {"01","02","03","04","05","06","07","08","09",
                                     "10","11","12","13","14","15","16","17","18",
                                     "19","20","21","22","23","24","25","26","27","28","29","30","31","32","33"};

        foreach (string i in xuy)
        {
            string[] lines = File.ReadAllLines("text\\input" + i + ".txt");
            string[] otvet = File.ReadAllLines("text\\output" + i + ".txt");
            Stopwatch st = new Stopwatch();

            //string[] inputs = Console.ReadLine().Split(' ');
            string[] inputs = lines[0].Split(' ');

            long N = long.Parse(inputs[0]);
            long X = long.Parse(inputs[1]);
            long Y = long.Parse(inputs[2]);

            //long[] temperatures = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            st.Start();
            long x = Method(N, X, Y);
            Console.WriteLine(x);
            st.Stop();
            if (x == long.Parse(otvet[0]))
                Console.WriteLine("\t Время выполнения: {0} \t ЗАДАНИЕ {1}   МОЛОДЕЦ ", st.Elapsed.TotalSeconds, i);
            else
                Console.WriteLine("\t Время выполнения: {0} \t ЗАДАНИЕ {1}   НЕПРАВИЛЬНО", st.Elapsed.TotalSeconds, i);
        }


    }
    public static long Method()
    {
        
    }
}

