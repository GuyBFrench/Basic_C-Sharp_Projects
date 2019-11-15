using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        
        

        
    }
}
