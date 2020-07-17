using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    /* Pass by value
     * C#은 메서드에 인수를 전달할 때, 
     * 디폴트로 값을 복사해서 전달하는 Pass by Value 방식을 따른다. 
     * 만약 전달된 인수를 메서드 내에서 변경한다해도 메서드가 끝나고 함수가 리턴된 후, 
     * 전달되었던 인수의 값은 호출자에서 원래 값 그대로 유지된다.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            int a = 5;
            int b = 10;
            calc.Double(a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            // c# out
            //int sum;
            //double avg;
            //calc.GetSumAndAvg(5, 15, out sum, out avg);
            calc.GetSumAndAvg(5, 15, out var sum, out var avg); // avg를 사용안하려면 out var avg -> out _로 바꿔주면 됨

            // c# params: 가변 파라미터
            int s = calc.Sum(1);
            s = calc.Sum(1, 2, 3, 4, 5);
            s = calc.Sum(1, 2, 3);

            // named parameter, optional parameter
            var st = new StudentList();
            st.AddStudent("lee", "5609-6802", 38);
            st.AddStudent(name: "lee", age: 38, phone: "5609-6802");
            st.AddStudent("lee", "5609-6802");
        }
    }

    class Calculator
    {
        public void Double(int a, ref int b)
        {
            a *= 2;
            b *= 2;
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }

        public bool GetSumAndAvg(int a, int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = sum / 2;
            Console.WriteLine("sum: {0}, avg: {1}", sum, avg);
            return true;
        }

        public int Sum(params int[] values)
        {
            int sum = 0;
            foreach (var v in values)
            {
                sum += v;
            }
            return sum;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }

    class StudentList
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string name, string phone, int age = 38)
        {
            var s = new Student();
            s.Name = name;
            s.Age = age;
            s.Phone = phone;
        }
    }
}
