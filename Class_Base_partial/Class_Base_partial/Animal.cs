using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Base_partial
{
    //베이스 클래스
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //파생 클래스
    public class Dog : Animal
    {
        public void HowOld()
        {
            Console.WriteLine("나이: {0}", this.Age);
        }
    }

    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("{0}가(이) 날다", this.Name);
        }
    }

    public abstract class PureBase
    {
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DerivedA : PureBase
    {
        private int no = 1;

        public override int GetFirst()
        {
            return no;
        }
        public override int GetNext()
        {
            return ++no;
        }
    }
}
