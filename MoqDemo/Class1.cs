using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo
{
    public class Class1 
    {
        private readonly Interface1 _interface1;
        
        public Class1(Interface1 obj)
        {
            _interface1 = obj;
        }

        public int DoSomething(int a , int b)
        {
            bool y= _interface1.DoSomething(1);
           return Add(a + b, a + b);
        }

        public int  Add(int a, int b)
        {
            return a + b;
        }
    }
}
