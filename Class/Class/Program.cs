using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Brick br = new Brick(); // 생성자를 의미
            Brick br2 = new Brick(50, 100, 20, Color.Gray);

            int w = br2.Width;
            br2.Width = -1;
            Color c = br2.Color;
            int v = br2.Volume;

            br2.ProcessStarted += Br2_ProcessStarted;
            br2.ProcessCompleted += Br2_ProcessCompleted;
            br2.MakeBrick();

            MyCustomer cus = new MyCustomer();
            string n = cus.Name;
            cus.Name = "lee";
            int a = cus.Age;

            cus.GetCustomerData();

            Program p = new Program();
            p.CheckInput(10, 30.085, DateTime.Now, null);
        }

        private static void Br2_ProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Complited");
        }

        private static void Br2_ProcessStarted(object sender, EventArgs e)
        {
            Console.WriteLine("Process Start");
        }

        double sum = 0;
        DateTime Time;
        bool? Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
            {
                this.sum = i.Value + d.Value;
                Console.WriteLine(sum);
            }
            if (!time.HasValue)
            {
                throw new ArgumentException();
            }
            else
            {
                this.Time = time.Value;
                Console.WriteLine(this.Time);
            }

            this.Selected = selected ?? false;
            Console.WriteLine(this.Selected);
        }
    }

    
}
