using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSuch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = new string[] { " Green. ", " Red. ", " Blue. ", " Orange. ", " Purple. "  };
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();

            for (int K = 0; K < stringArray1.Length; K++)
            {
                Console.WriteLine(userName + "'s favorite color might be" + stringArray1[K]);
            }
            Console.ReadLine();

            List<string> colorList = new List<string>() { "Green", "green", "Red", "red", "Orange", "orange", "Blue", "blue", "Yellow", "yellow", "Purple", "purple", "Pink", "pink", "Ocher", "ocher" };

            Console.WriteLine("I have a list of colors, enter a color and we will see if I have that one.");
            string userColor = Console.ReadLine();

            foreach (string color in colorList)
            {
                if (color == userColor)
                {
                    Console.WriteLine("I have that one! In my List its in position " + colorList.IndexOf(color));
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Its not in this position sorry");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();

            List<string> stateList = new List<string>() { "Texas", "Hawaii", "Louisiana", "Oregon", "Texas", "Texas", "Californina", "Idaho", "Kentucky", "New York", "Florida", "Utah", "Georgia", "Washington" };

            Console.WriteLine("Please enter your favorite states Name, such as Arizona, and we will see if anyone else that weve asked has the same favorite state.");
            string userState = Console.ReadLine();

            foreach (string state in stateList)
            {
                if (state == userState)
                {
                    Console.WriteLine("Someone else had that one as well!" + stateList.IndexOf(state));
                    Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("No one else had that one sorry");
                    Console.ReadLine();
                    return;
                }
            }


        }
    }
}
