
namespace ExceptionHandlingcon
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new AgeException("Invalid Age.You are not eligible to vote");
                }

                Console.WriteLine("Enter the value of a:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the value of b:");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
                int[] ar = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(ar[i]);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //used to release the resources/close the database connection/close the file
                Console.WriteLine("End of the program");
            }



        }
    }
}