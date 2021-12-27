using System;

namespace Dependency.Service
{
    
    public interface IA
    {
        void Hello();
    }
    public class A : IA
    {
        IB b;
        public A(IB b)
        {
            this.b = b;
        }
        public void Hello()
        {
            Console.Write($"A:IA (IB) B={b.GetHashCode()} ");
            b.Hi();
        }
    }
}
