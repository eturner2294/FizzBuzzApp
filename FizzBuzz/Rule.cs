﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface Rule
    {
        Boolean ruleSatisfied(int val);

        void doThing();
    }
}
