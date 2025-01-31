using GenericCollections;

//Generic - Type Specific


List<string> courses = new List<string>();
courses.Add("DotNet");
courses.Add("Angular");

foreach(string course in courses)
{
    Console.WriteLine(course);
}

List<Customer> cst = new List<Customer>();
cst.Add(new Customer() { CustId = 111, Name = "Reena" });
cst.Add(new Customer() { CustId = 111, Name = "Reena" });
cst.Add(new Customer() { CustId = 111, Name = "Reena" });

foreach(Customer cust in cst)
{
    Console.WriteLine(cust.CustId+" "+cust.Name);
}

Stack<int> stk = new Stack<int>();
stk.Push(1);
stk.Push(2);
stk.Push(3);
stk.Push(4);

foreach (int i in stk)
{
    Console.WriteLine(i);
}

Console.WriteLine(stk.Peek());
Console.WriteLine();//display the top most element
foreach (int i in stk)
{
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine(stk.Pop());
Console.WriteLine();
foreach (int i in stk)
{
    Console.WriteLine(i);
}

Queue<string> qu = new Queue<string>();
qu.Enqueue("Hello");
qu.Enqueue("Hi");
foreach (string str in qu)
{
    Console.WriteLine(str);
}

Dictionary<int,string> dic = new Dictionary<int,string>();
dic.Add(1, "HI");
dic.Add(2, "Hello");

foreach(KeyValuePair<int,string> kvp in dic)
{
    Console.WriteLine(kvp.Key+" "+kvp.Value);
}

HashSet<string> hsh = new HashSet<string>();
hsh.Add("Dotnet");
hsh.Add("CSharp");
hsh.Add("Dotnet");

foreach(string str in hsh)
{
    Console.WriteLine(str);
}
SortedList<int, string> srt = new SortedList<int, string>();
srt.Add(11, "HI");
srt.Add(2, "Hello");
srt.Add(20, "Hello");
srt.Add(12, "Hello");
foreach (KeyValuePair<int, string> str in srt)
{
    Console.WriteLine(str.Key + " "+str.Value);
}
