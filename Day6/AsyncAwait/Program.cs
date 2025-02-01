// See https://aka.ms/new-console-template for more information
//Asynchronous streams - IAsyncEnumerable<T> 

async Task<List<int>> GetNumberAsync()
{
    await Task.Delay(1000);//simulate data fetching
    return new List<int>() { 11, 12, 13, 14, 15 };
}
List<int> list = await GetNumberAsync(); //waits for all the values
foreach(int i in list)
{
    Console.WriteLine(i);
}
Console.WriteLine("Hi");
await foreach (var num in GetNumbersAsync())
{
    Console.WriteLine(num);
}

static async IAsyncEnumerable<int> GetNumbersAsync() //return multiple values and await foreach
{
    for (int i = 0; i < 10; i++)
    {
        await Task.Delay(1000);
        yield return i;
    }
}

DisplayTwo();
Displayone();

static void Displayone()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        //Thread.Sleep(2000);
        Task.Delay(2000).Wait();
        
    }
}
static async void DisplayTwo()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i);
           // Thread.Sleep(2000);
        }
    });
    
}





