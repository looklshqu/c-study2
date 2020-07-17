using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[]
            //{
            //    "Seattle", "Parris", "London"
            //};
            //foreach (string city in cities)
            //{
            //    Console.WriteLine("city: {0}", city);
            //}

            //string menu;
            //do
            //{
            //    Console.WriteLine("Select city: (S)eattle (P)aris (L)ondon (Q)uit");
            //    menu = Console.ReadLine();
            //    Console.WriteLine(menu + " is selected.");
            //} while (menu != "Q");

            //List<char> keyList = new List<char>();
            //ConsoleKeyInfo key;
            //do
            //{
            //    key = Console.ReadKey();
            //    keyList.Add(key.KeyChar);
            //} while (key.Key != ConsoleKey.Q);
            //Console.WriteLine();

            //foreach (char ch in keyList)
            //{
            //    Console.WriteLine("ch: {0}", ch);
            //}

            int n = 1;
            int sum = 0;
            while (n <= 100)
            {
                if (n % 11 == 0)
                {
                    n++;
                    //break;
                    continue;
                }
                sum += n;
                n++;
            }
            Console.WriteLine(sum);
        }
    }
}
