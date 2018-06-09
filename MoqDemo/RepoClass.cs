using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqDemo
{
    public class RepoClass : Interface1
    {
        public bool DoSomething(int i)
        {
            if (i < 0)
            {
                throw new NotImplementedException();
            }
            else if (i == 1)
            {
                return false;
            }
            return true;
        }
            
    }
}
