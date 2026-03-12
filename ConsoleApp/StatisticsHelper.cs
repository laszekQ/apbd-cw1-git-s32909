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
    
    public static double CalculateAverage(int[] arr)
    {
        double sum = 0.0;
        
        foreach (double e in arr) 
        {
            sum += e;
        }
        
        return sum / arr.Length;
    }

    public static int CalculateMax(int[] arr)
    {
        int max = int.MinValue;
        foreach (int e in arr)
            if (e > max)
                max = e;
        return max;
    }
    
    public static double CalculateMaxDouble(double[] arr)
    {
        double max = double.MinValue;
        foreach (double e in arr)
            if (e > max)
                max = e;
        return max;
    }
    
    public static double CalculateMin(double[] arr)
    {
        double min = double.MaxValue;
        foreach (double e in arr)
            if (e < min)
                min = e;
        return min;
    }

    public static int CalculateMinInt(int[] arr)
    {
        int min = int.MaxValue;
        foreach (int e in arr)
            if (e < min)
                min = e;
        return min;
    }

    public static double CalculateMedian(double[] arr)
    {
        int len = arr.Length;
        
        if (arr.Length % 2 == 0)
        {
            return (arr[len / 2 - 1] + arr[len / 2]) / 2;
        }
        else
        {
            return arr[len / 2];
        }
    }

    public static double CalculateMinimumInRange(double[] arr, int from, int to)
    {
        double min = double.MaxValue;
        for (int i = from; i < to; i++)
        {
            if(arr[i] < min)
                min = arr[i];
        }
        return min;
    }
}