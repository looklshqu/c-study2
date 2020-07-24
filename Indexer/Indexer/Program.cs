using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyClass
    {
        private const int MAX = 10;
        private string name;

        private int[] data = new int[MAX];

        // 인덱서 정의, int 파라미터 사용
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= MAX)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if (!(index < 0 || index >= MAX))
                {
                    data[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cls = new MyClass();

            //set
            cls[1] = 1024;

            //get
            int i = cls[1];
        }
    }
}
