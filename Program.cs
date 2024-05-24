using System;

public class Timer
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    public Timer()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public double GetElapsedTime()
    {
        TimeSpan elapsed = endTime - startTime;
        return elapsed.TotalMilliseconds;
    }
}

public class Baitap29
{ 
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    public static void Main()
    {
        const int size = 100000;
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000000); // Random numbers 0 and 999999
        }
        Timer timer = new Timer();
        timer.Start();
        SelectionSort(numbers);
        timer.Stop();
        double elapsedTime = timer.GetElapsedTime();
        Console.WriteLine($"Time taken to sort {size} numbers: {elapsedTime} milliseconds");
    }
}