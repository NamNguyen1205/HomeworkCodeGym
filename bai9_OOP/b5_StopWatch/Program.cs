public class StopWatch
{
    private DateTime startTime { get; set; }
    private DateTime endTime { get; set; }

    public StopWatch()
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
    public long GetElapsedTime()
    {
        return (long)(endTime - startTime).TotalMilliseconds;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int size = 100000;
        int[] numbers = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000000);
        }

        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();
        SelectionSort(numbers);
        stopWatch.Stop();
        Console.WriteLine("Time taken to sort " + size + " numbers using Selection Sort: " + stopWatch.GetElapsedTime() + " ms");
    }

    static void SelectionSort(int[] arr)
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
}