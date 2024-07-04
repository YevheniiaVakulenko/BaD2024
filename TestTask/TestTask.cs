using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestTask
{
    public static int? FindMin(int[] arr)
    {
        if (arr.Length == 0) { return null; }
        return arr[0];
    }
    public static int? FindMax(int[] arr)
    {
        if (arr.Length == 0) { return null; }
        return arr[arr.Length - 1];
    }

    public static double FindMedian(int[] arr)
    {
        double medval = 0.0;
        if (arr.Length == 0) { return medval; }
        int i = arr.Length / 2;
        if (arr.Length % 2 == 0)
        {
            medval = (double)((arr[i - 1] + arr[i]) * 0.5);
        }
        else
        {
            medval = arr[i];
        }
        return medval;
    }

    public static double FindAvg(int[] arr)
    {
        double avgval = 0.0;
        if (arr.Length == 0) { return avgval; }
        long sum = arr.Sum(x => (long)x);
        avgval = ((double)sum / arr.Length);
        return avgval;
    }


    public static List<int> FindMinMaxSeq(int[] arr, bool direction)
    {
        //direction true - asc, false - desc
        List<int> bestResult = new List<int>();
        if (arr.Length == 0) return bestResult;
        List<int> currentSeq = new List<int>();
        currentSeq.Add(arr[0]);
        for (int c = 1; c < arr.Length; c++)
        {
            if (direction)
            {
                if (arr[c] > arr[c - 1]) { currentSeq.Add(arr[c]); }
                else
                {
                    if (currentSeq.Count > bestResult.Count) { bestResult = new List<int>(currentSeq); }
                    currentSeq.Clear();
                    currentSeq.Add(arr[c]);
                }
            }
            else
            {
                if (arr[c] < arr[c - 1]) { currentSeq.Add(arr[c]); }
                else
                {
                    if (currentSeq.Count > bestResult.Count) { bestResult = new List<int>(currentSeq); }
                    currentSeq.Clear();
                    currentSeq.Add(arr[c]);
                }
            }
        }
        if (currentSeq.Count > bestResult.Count) { bestResult = new List<int>(currentSeq); }
        return bestResult;
    }
}
