using System.ComponentModel;

namespace ClassMethodStaticDemo
{
    internal class Program
    {
        static void Display(ref int n)//Method Definition
        {
            n *= 20;//400
            Console.WriteLine("Value inside the Method" + n);
        }
        static void OutSample(out int n)//Method Definition
        {
            // n *= 20;//400
            int a = 20;
            n = 20*a;
            Console.WriteLine("Value inside the Method" + n);
        }
        static int Division(int a,int b,out int r)
        {
            r = a % b;//remainder will be returned as out parameter
            return a / b;//quotient is returning
        }
        void Show() //Instance Mthd
        {
            Console.WriteLine("Instance Method");
        }
        //Method with reurn type
        int add(int a,int b)
        {
            return a+ b;
        }
        private static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // Program pgm = new Program();
            // pgm.Show();
            // int a =20;
            //Console.WriteLine("The value of a:" + a);
            // Display(ref a);//Method Calling
            // Console.WriteLine("The value of a after calling display method:" + a);
            // int result = pgm.add(50, 60);
            // Console.WriteLine("Sum is" + result);
            // Console.WriteLine(pgm.add(10, 20));

            // //Out parameter
            // OutSample(out a);
            // Console.WriteLine("The value of a after calling OutSample method:" + a);
            // int res;
            // Console.WriteLine(Division(100,5,out res));
            // Console.WriteLine(res);


            Employee[] emp = new Employee[5];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter EmployeeId:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter EmployeeName:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Dept");
                string dpt = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                emp[i] = new Employee(id, name, dpt, sal);

            }
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i].EmpId + " " + emp[i].EmpName);
            }
        }
    }
}
