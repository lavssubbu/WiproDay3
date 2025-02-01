internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Outer try block starts.");
            int res = 10 / int.Parse("0");
            try
            {
                Console.WriteLine("Inner try block starts.");
                int[] nums = { 10, 11, 12 };
                Console.WriteLine(nums[10]);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Inner Catch:" + ex.Message);
            }          

        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Outer Catch:" + ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("EndProgram");
        }
    }
}