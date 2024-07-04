using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

public class Program
{
    const string textFile = "10m.txt";
    public static void Main(string[] args)
    {
        try
        {
            string[] lines = File.ReadAllLines(textFile);
            int[] array = Array.ConvertAll(lines, int.Parse);

            var watch = Stopwatch.StartNew();

            List<int> ascSeq, descSeq;
            ascSeq = TestTask.FindMinMaxSeq(array, true);
            descSeq = TestTask.FindMinMaxSeq(array, false);
            Array.Sort(array);
            var max = TestTask.FindMax(array);
            var min = TestTask.FindMin(array);
            var median = TestTask.FindMedian(array);
            var avg = TestTask.FindAvg(array);

            watch.Stop();

            Console.WriteLine($"The Execution time of the program is {watch.Elapsed.TotalSeconds}s");
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Median: " + median);
            Console.WriteLine("Avg: " + avg);
            Console.WriteLine("Assceding: " + string.Join(", ", ascSeq));
            Console.WriteLine("Desceding: " + string.Join(", ", descSeq));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
    }
}