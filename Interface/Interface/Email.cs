using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Email : ISendable
    {
        private string email = "looklsh@qubesoft.kr";
        public void Send(string msg)
        {
            Console.WriteLine($"Email {msg} to {email}");
        }

        public bool ValidateEmail()
        {
            return true;
        }
    }

}
