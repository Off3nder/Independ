using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.Service
{
    public interface IB
    {
        void Hi();
    }
    public class B : IB
    {
        public B ()
        {

        }
        public void Hi()
        {
            Console.WriteLine("Hi!");
        }
    }
}
