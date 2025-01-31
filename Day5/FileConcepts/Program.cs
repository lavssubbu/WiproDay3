using FileConcepts;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
       // FileStream fs = new FileStream("Sample.txt", FileMode.OpenOrCreate);
        //StreamWriter sw = new StreamWriter(fs);
        //sw.WriteLine("Welcome to File Concepts");
        //sw.WriteLine("Second Line");
        //Console.WriteLine("File created successfully");        

       // StreamReader sr = new StreamReader(fs);
        // Console.WriteLine(sr.ReadLine());
        // Console.WriteLine(sr.ReadToEnd());
        //string res = "";
        //while ((res=sr.ReadLine()) != null)
        //{
        //    Console.WriteLine(res);
        //}

        //Account[] acc = new Account[3];
        //for (int i = 0; i < acc.Length; i++)
        //{
        //    Console.WriteLine("Enter id,name,balance:");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    string name = Console.ReadLine();
        //    int bal = Convert.ToInt32(Console.ReadLine());
        //    acc[i] = new Account() { Accid = id, AccName = name, AccBalance = bal };

        //}
        Account acc = new Account() { Accid = 1, AccName = "Zara", AccBalance = 50000 };
        string data = JsonConvert.SerializeObject(acc);
        Console.WriteLine(acc);
        FileStream fs = new FileStream("Sample.txt", FileMode.OpenOrCreate);
        StreamWriter stw = new StreamWriter(fs);
        stw.WriteLine(acc);
        Console.WriteLine("File created successfully");
        stw.Close();
        fs.Close();
        
    }
}