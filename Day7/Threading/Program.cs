internal class Program
{
    private static int count = 0;
    private static readonly object lockObj = new object();


    static void IncrementCount()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObj) // Locking the critical section
            {
                count++;
                Console.WriteLine(count);
            }
        }
    }
    //static void PrintNumbers(object obj)
    //{
    //    int count = (int)obj;
    //    for (int i = 1; i <= count; i++)
    //    {
    //        Console.WriteLine(i);
    //        Thread.Sleep(1000); // Sleep for 0.5 seconds
    //    }
    //}
    private static void Main(string[] args)
    {
        //ThreadPool.QueueUserWorkItem(PrintNumbers, 5);
        //Console.WriteLine("Main thread is running");

        //// Wait for the thread pool task to complete
        //Thread.Sleep(3000); // Sleep to let the thread pool work
        //Console.WriteLine("Thread pool task completed");

        Thread thread1 = new Thread(IncrementCount);
        Thread thread2 = new Thread(IncrementCount);

        // Start the threads
        thread1.Start();
        thread2.Start();

        // Wait for threads to complete
        thread1.Join();
        thread2.Join();

        // Output the final count (should be 2000)
        Console.WriteLine($"Final count: {count}");
    }
}
