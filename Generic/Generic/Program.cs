using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var iCalc = new Calculator<int>();
            var x = iCalc.Add(2, 3);
            Console.WriteLine(x);

            var dCalc = new Calculator<double>();
            var y = dCalc.Multi(4.2, 5.6);
            Console.WriteLine(y);

            List<string> nameList = new List<string>();
            nameList.Add("홍길동");
            Console.WriteLine(nameList);

            List<int> intList = new List<int>();
            intList.Add(100);
            Console.WriteLine(intList);

            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("홍길동", 200);
            Console.WriteLine(scores);
        }
    }
}
