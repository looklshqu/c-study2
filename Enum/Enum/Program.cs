using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum City
        {
            Seoul,
            Kwangju,
            Daejun,
            Busan
        }

        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("[Enum]에 대하여");
            Console.WriteLine();
            City myCity;
            myCity = City.Seoul;
            Console.WriteLine("{0}", myCity);


            int cityValue = (int)myCity;
            Console.WriteLine(cityValue);

            if (myCity == City.Seoul)
            {
                Console.WriteLine("Welcome to Seoul");
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("[Flags]에 대하여");
            Console.WriteLine();

            Border b = Border.Top | Border.Bottom;

            if ((b & Border.Top) != 0)
            {
                if (b.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(b.ToString());
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            int i = 1;
            Console.WriteLine(++i);

            int x = 0;
            int y = 1;
            if (++x > 0 || ++y > 1)
            {

            }
            Console.WriteLine(x + y);
        }
    }
}
