using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _162_Const
{
    class Program
    {
        static void Main(string[] args)
        {
            const string programName = "The Program";

            var theList = new Dictionary<string, string>();
        }
    }
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Name { get; set; }

        public People(string firstName, string lastName)
        {
            Name = firstName + lastName; 
        }
        public People(string firstName) : this(firstName, "Johnson")
        {
        }
    }
}
