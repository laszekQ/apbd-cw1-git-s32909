using System.Numerics;

namespace ConsoleApp;

public static class StatisticsHelper
{
    public static double CalculateAverage(double[] arr)
    {
        double sum = 0.0;
        
        foreach (double e in arr) 
        {
            sum += e;
        }
        
        return sum / arr.Length;
    }

    public static double CalculateMedian(double[] arr)
    {
        int len = arr.Length;
        
        if (arr.Length % 2 == 0)
        {
            return (arr[len / 2] + arr[len / 2 + 1]) / 2;
        }
        else
        {
            return arr[len / 2];
        }
    }
}