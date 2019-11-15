using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Person
    {
        public string Name { get; set; }
        

        public Person()
        {
            Name = "Tickle";
            
        }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
}
