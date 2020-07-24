using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Base_partial
{
    class MyBase
    {

    }

    class MyClass : MyBase
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Age = 6;
            dog.HowOld();

            Bird bird = new Bird();
            bird.Name = "앵그리버드";
            bird.Fly();

            DerivedA da = new DerivedA();
            int a = da.GetFirst();
            int b = da.GetNext();
            Console.WriteLine(a);
            Console.WriteLine(b);

            MyClass c = new MyClass();
            new Program().Test(c);
            
        }

        public void Test(object obj)
        {
            MyBase a = obj as MyBase;
            Console.WriteLine(a);

            bool ok = obj is MyBase;
            Console.WriteLine(ok);

            MyBase b = (MyBase)obj;
        }
    }
}
