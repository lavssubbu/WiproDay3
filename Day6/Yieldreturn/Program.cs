internal class Program
{
    private static void Main(string[] args)
    {
        foreach(string country in PrintCountry('u'))
        {
            Console.WriteLine(country);
        }
    }
    static IEnumerable<string> PrintCountry(char chr) //u
    {
        List<string> countries = new List<string>() { "India", "US", "UK", "Europe" }; //original list

      //  List<string> countrieswithchar = new List<string>(); //empty list

        for(int i=0;i<countries.Count;i++)
        {
            if (countries[i].ToLower().Contains(chr))//charcter - u
            {
                Console.WriteLine(i.ToString());
                //  countrieswithchar.Add(countries[i]);
                yield return countries[i]; //iteration blocker  - provide the next value in the iteration
            }
        }
       //return countrieswithchar;
    }
}