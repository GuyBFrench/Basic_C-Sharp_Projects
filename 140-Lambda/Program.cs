using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> First = new Employee<string>();
            First.Things = new List<string>();
            Employee<string> Last = new Employee<string>();
            Last.Things = new List<string>();
            Employee<int> Id = new Employee<int>();
            Id.Things = new List<int>();
            

            List<string> nameFirst = new List<string>();


            Id.Things.Add(1);
            Id.Things.Add(2);
            Id.Things.Add(3);
            Id.Things.Add(4);
            Id.Things.Add(5);
            Id.Things.Add(6);
            Id.Things.Add(7);
            Id.Things.Add(8);
            Id.Things.Add(9);
            Id.Things.Add(10);

            First.Things.Add("Pete");
            First.Things.Add("Alison");
            First.Things.Add("Aaron");
            First.Things.Add("Guy");
            First.Things.Add("Joe");
            First.Things.Add("Jacob");
            First.Things.Add("Emily");
            First.Things.Add("Joe");
            First.Things.Add("Elizabeth");
            First.Things.Add("John");


            Last.Things.Add("Johnson");
            Last.Things.Add("Dalmer");
            Last.Things.Add("O'Rielly");
            Last.Things.Add("Andrew");
            Last.Things.Add("Johnson");
            Last.Things.Add("Ehlers");
            Last.Things.Add("Otea");
            Last.Things.Add("Solana");
            Last.Things.Add("French");
            Last.Things.Add("Jackson");

            foreach (string name in First.Things)
            {
                if (name == "Joe")
                {
                    nameFirst.Add(name);
                }
                    
            }

            
            List<> listId = First.Things.Where(x => x.Id.things > 5);

            Console.ReadLine();




        }
    }
}
