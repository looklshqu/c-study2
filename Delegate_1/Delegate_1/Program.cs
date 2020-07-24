using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
        }

        // 델리게이트 정의
        delegate int MyDelegate(string s);

        void Test()
        {
            // 델리게이트 객체 생성
            MyDelegate m = new MyDelegate(StringToInt);
            // 델리게이트 객체 메서드로 전달
            Run(m);
        }

        // 델리게이트 대상이 되는 어떤 메서드
        int StringToInt(string s)
        {
            return int.Parse(s);
        }

        void Run(MyDelegate m)
        {
            int i = m("123");
            Console.WriteLine(i);
        }
    }
}
