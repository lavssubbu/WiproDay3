using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Type T = Type.GetType("ReflectionConcept.Employee");
        Console.WriteLine(T.Name);
        Console.WriteLine(T.FullName);

        MethodInfo[] mthds = T.GetMethods();
        Console.WriteLine(mthds.GetType);
        Console.WriteLine(mthds.GetType().FullName);
        foreach (MethodInfo method in mthds)
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        }

        ConstructorInfo[] ctors = T.GetConstructors();
        Console.WriteLine(ctors.GetType());
        foreach (ConstructorInfo constructor in ctors)
        {
            Console.WriteLine(constructor.ToString());
        }


    }
}
