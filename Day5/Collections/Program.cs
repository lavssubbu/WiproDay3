using System.Collections;

ArrayList arrlst = new ArrayList();
arrlst.Add(111);//Boxing
arrlst.Add("Wipro");
arrlst.Add(true);
Console.WriteLine(arrlst);
foreach(object i in arrlst)
{
    Console.WriteLine(i);
}
Console.WriteLine("Capacity of arlst:" + arrlst.Capacity);
Console.WriteLine("Number of items in ArrayList:" + arrlst.Count);
Console.WriteLine();
string[] cities = { "Chennai", "Bangalore", "Hyderabad", "Bihar" };
arrlst.AddRange(cities);
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}
Console.WriteLine();

Console.WriteLine("Capacity of arlst:" + arrlst.Capacity);
Console.WriteLine("Number of items in ArrayList:" + arrlst.Count);
arrlst.Insert(1, 1000);
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}
Console.WriteLine();

int[] ar = { 10, 20, 30 };
arrlst.InsertRange(3, ar);
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}

Console.WriteLine("Capacity of arlst:" + arrlst.Capacity);
Console.WriteLine("Number of items in ArrayList:" + arrlst.Count);

Console.WriteLine();
arrlst.Remove("Chennai");
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}
Console.WriteLine();
arrlst.RemoveAt(2);
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}

arrlst.RemoveRange(1, 3);
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}

arrlst[1] = "Update";
foreach (object i in arrlst)
{
    Console.WriteLine(i);
}

Console.WriteLine(arrlst.Contains("bangalore"));

ArrayList intarr = new ArrayList();
intarr.Add(111);
intarr.Add(112);//Boxing - value type(int) converted to ref type(object)

foreach(int item in intarr)
{
    Console.WriteLine(item);//Unboxing 
}

//Non Generic - slow performance compared to generics because of automatic boxing and unboxing
