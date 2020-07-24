using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da + db;
            return result;
        }
        public T Subs(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da - db;
            return result;
        }
        public T Multi(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da * db;
            return result;
        }
        public T Div(T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            T result = da / db;
            return result;
        }
    }
}
