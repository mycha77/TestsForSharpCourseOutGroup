﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.HomeWorks
{
    public class ClassTest2 : ClassTestBase
    {
        public ClassTest2()
        {

        }

        public override string Print()
        {
            return "It is ClassTest2";
        }

        public override string PrintFromInterface()
        {
            return "It is ClassTest2Interface";
        }
    }
}
