using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstractcls
{
    abstract class Flight
    {
        public int FlightNo { get; set; }
        public string FlightName { get; set; }

        public void FlightDetails()//Method definition - Normal Method
        {
            Console.WriteLine(FlightNo + " " + FlightName);
        }

       public abstract void FareDetails();//Method declaration - abstract keyword - abstract class
    }
    class FlightFare : Flight //derived class
    {
        public decimal BasicFare { get; private set; }
        public int durationinhrs { get; set; }
        public string typedes { get; set; }

        public override void FareDetails()
        {
            if (durationinhrs > 4)
            {
                BasicFare = 8000;
            }
            else
            {
                BasicFare = 5000;
            }
            if (typedes.ToLower().Equals("international"))
            {
                BasicFare += 10000;
            }
            Console.WriteLine($"BasicFare:{BasicFare}");
        }
    }

}
