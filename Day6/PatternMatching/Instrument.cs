using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo
{
    internal class Instrument
    {
    }
    class Stock : Instrument
    {
        public string volatility = "High";
    }
    class SNP100IndexFund : Stock
    {

    }
    class MutualFund : Stock
    {

    }
    class Bond : Instrument
    {
        public string volatility = "Low";
    }
    class Alternate : Instrument
    {
        public string volatility = "Moderate";
    }
}
