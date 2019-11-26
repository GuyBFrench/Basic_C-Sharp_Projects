using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _165_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int userAge = Convert.ToInt32(Console.ReadLine());
                int userYear = 2019 - userAge;
                Console.WriteLine("The year you were born is {0}.", userYear);
                Console.ReadLine();
                if (userAge < 0)
                {
                    throw new NegativeException();
                }
                if (userAge == 0)
                {
                    throw new ZeroException();
                }

            }

            catch (ZeroException)
            {
                Console.WriteLine("You cannot be 0 years old.");
                Console.ReadLine();
                return;
            }
            catch (NegativeException)
            {
                Console.WriteLine("You cannot be negative years old.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter your age, only using digits.");
                Console.ReadLine();
                return;
            }
        }
    }
    public class NegativeException : Exception
    {
        public NegativeException()
              : base() { }
        public NegativeException(string message)
            : base(message) { }
    }
    public class ZeroException : Exception
    {
        public ZeroException()
              : base() { }
        public ZeroException(string message)
            : base(message) { }
    }
}
