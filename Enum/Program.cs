using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _134_Enum
{
    class Program
    {

        enum TheDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string userInput = Console.ReadLine();

                

                TheDay userDay = Enum.TryParse(userInput);
                
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Please enter an actual day of the week.");      
            }

        }
        
    }

    
}
