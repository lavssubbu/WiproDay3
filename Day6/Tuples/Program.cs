//class - full fledged object - class members,methods - better for complex data ,Can modified
using System.Net.Cache;

var person = ("John", 30, "Engineer");//Tuple immutable - store group of values without defining a structure
Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}, Job: {person.Item3}");

//Named tuple
var person2 = (Name:"John",Age: 30,Designation: "Engineer");
Console.WriteLine($"Name: {person2.Name}, Age: {person2.Age}, Job: {person2.Designation}");

//Tuple deconstruction - extract the values from the tuples
var (name, age, job) = ("Alice", 28, "Doctor");
Console.WriteLine($"Name: {name}, Age: {age}, Job: {job}");

//Tuple deconstruction using method
//Anonymous Method - Method without name
// => Lambda expression
(string, int, string) GetPerson() => ("Bob", 40, "Lawyer"); 

var (nam, ag, jb) = GetPerson();//output of GetPerson() - ("Bob", 40, "Lawyer") 
Console.WriteLine($"Name: {nam}, Age: {ag}, Job: {jb}");

(string category, double price) product = ("Clothing", 1100);

string discount = product switch
{
    ("Electronics", > 1000) => "10% discount",
    ("Electronics", <= 1000) => "5% discount",
    ("Clothing", _) => "15% discount",// _ discard - omit price value
    _ => "No discount" //default case
};

Console.WriteLine(discount);

//nested tuple

var order = ("Laptop", 1500, ("Canada", "gfjgg"));

string shippingCost = order switch
{
    ("Laptop", > 1000, ("US", "Express")) => "Free Shipping",
    ("Laptop", > 1000, ("US", _)) => "$10 Shipping",
    (_, _, ("Canada", _)) => "$20 Shipping",
    _ => "$30 Shipping"
};

Console.WriteLine(shippingCost);

(int score, bool isBonus) gameResult = (85, true);

string message = gameResult switch
{
    ( > 90, true) => "Excellent! Bonus Applied",
    ( > 90, false) => "Excellent!",
    ( >= 70, true) => "Good Job! Bonus Applied",
    ( >= 70, false) => "Good Job!",
    _ => "Keep Trying!"
};

Console.WriteLine(message);
