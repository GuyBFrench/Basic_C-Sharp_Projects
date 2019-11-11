using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>() { 23, 54, 985, 44, 86, 320, 745, 9512, 158, 7889, 2103, 222, 20, 4, 458 };
                Console.WriteLine("Please enter a whole number. I will divide each of my numbers by yours.");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                for (int K = 0; K < intList.Count; K++)
                {
                    Console.WriteLine(intList[K] / userNumber);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program encountered a try/catch block and continued.");
                Console.ReadLine();
            }

        }
    }
}
