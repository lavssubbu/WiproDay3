using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int num1, num2, res;
            try
            {
                Console.WriteLine("Enter firstnumber");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter firstnumber");
                num2 = Convert.ToInt32(Console.ReadLine());

                res = num1 / num2;
                Console.WriteLine($"Result={res}");

            }
            //Inner catch
            catch (Exception ex)
            {
                string FilePath = "Log.txt";
                FileStream fsw = new FileStream(FilePath, FileMode.OpenOrCreate);
                if (File.Exists(FilePath))
                {
                    StringBuilder str = new StringBuilder();
                    str.Append($"Message:{ex.Message}\n");
                    str.Append($"Source:{ex.Source}\n");
                    str.Append($"StackTrace:{ex.StackTrace}\n");
                    str.Append($"GetType():{ex.GetType()}\n");
                    str.Append($"GetType()Name:{ex.GetType().Name}\n");
                  

                    StreamWriter stw = new StreamWriter(fsw);
                    stw.Write(str.ToString());
                    stw.Close();
                    fsw.Close();
                    Console.WriteLine("There is  a Problem");

                }
                else
                {
                    string msg = FilePath + "Doesnot exist";
                    throw new FileNotFoundException(msg,ex);
                }
            }
        }
        catch(Exception e)
        {
            Console.WriteLine("Current Exception DEtails");
            Console.WriteLine($"Message:{e.Message}\n");
            Console.WriteLine($"Source:{e.Source}\n");
            Console.WriteLine($"StackTrace:{e.StackTrace}\n");

            if (e.InnerException != null)
            {
                Console.WriteLine($"InnerException:{e.InnerException.Message}");
                Console.WriteLine($"InnerException:{e.InnerException.Source}");
            }
        }
        Console.WriteLine("MainEnd");
    }
}