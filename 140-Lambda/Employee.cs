﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140_Lambda
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
        public int Id { get; set; }
        public  string firstName { get; set; }
        public string lastName { get; set; }
    }
}
