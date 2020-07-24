using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISendable> deliveryMethods = new List<ISendable>();
            deliveryMethods.Add(new Email());

            Alert(deliveryMethods, "Emergency msg...");
        }

        private static void Alert(List<ISendable> deliveryMethods, string msg)
        {
            foreach (ISendable s in deliveryMethods)
            {
                s.Send(msg);
            }
        }
    }
}
