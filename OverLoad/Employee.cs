﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Employee : Person, IQuitable
    {
        public override void SayName()
        {
            base.SayName();
        }

        void IQuitable.Quit()
        {
            throw new NotImplementedException();
        }
    }
}
