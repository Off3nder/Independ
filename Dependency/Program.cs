using Dependency.Service;
using System;

namespace Dependency
{
    class Program
    {
        static void Main(string[] args)
        {
            var DIContainer = new dependyy();

            DIContainer.AddTransient<IA, A>();
            DIContainer.AddSingleton<IB, B>();

            var tr_1 = DIContainer.GetService<IA>();
            tr_1.Hello();

            var tr_2 = DIContainer.GetService<IA>();
            tr_2.Hello();
            Console.WriteLine(tr_1.GetHashCode())
                ;Console.WriteLine(tr_2.GetHashCode());

            var st_1 = DIContainer.GetService<IB>();
            var st_2 = DIContainer.GetService<IB>();

            Console.WriteLine(st_1.GetHashCode());
            Console.WriteLine(st_2.GetHashCode());

            
        }
    }
}
