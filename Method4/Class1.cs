using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method4
{
    class Class1
    {
        public void theVoid(int A)
        {
            int B = A / 2;
            Console.WriteLine(B);
            Console.ReadLine();
        }

        static void theVoid(int A, int C)
        {
            int B = A / 2;
            Console.WriteLine(B);
            Console.ReadLine();
        }
    }
}
