namespace PatternMatchingDemo
{
    public enum ErrorCode
    {
        NotFound=1,
        InternalServerError,
        Unauthorised
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
           Console.WriteLine(GetVolatility(new Stock()));
            Console.WriteLine(GetVolaitilitywithswitch(new SNP100IndexFund()));

            ErrorCode errorCode = (ErrorCode)1;

            //Property pattern matching -switch string
            int statusCode = errorCode switch
            {
                ErrorCode.InternalServerError => 500,
                ErrorCode.NotFound => 404,
                ErrorCode.Unauthorised => 401,
                _ => 500
            };
            Console.WriteLine(statusCode);
        }
        //passing instance in the parameter
        //Object pattern matching using is keyword,when condition in switch case, switch string
        static string GetVolatility(Instrument ins)
        {
            if (ins is Stock s ) //extraction of object from the match and use it
                return s.volatility;
            if(ins is Bond b)
                return b.volatility;
            if(ins is Alternate a)
                return a.volatility;
            return "NoMatchFound";

        }
        static string GetVolaitilitywithswitch(Instrument ins)
        {
            //switch (ins)
            //{
            //    case Stock st when st is SNP100IndexFund:
            //        return "Moderate";
            //    case Stock st when st is MutualFund:
            //        return "High";
            //    default:
            //        return "NoMatchFound";
            //}

            //switch string
            return ins switch
            {
                SNP100IndexFund => "Moderate",
                MutualFund => "High",
                Stock s => s.volatility,
                Bond b => b.volatility,
                Alternate a => a.volatility,
                _ => "NoMatchFound"
            };
        }
    }
}