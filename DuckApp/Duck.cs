﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckApp
{
    class Duck : IComparable<Duck>
    {
        public int Size
        {
            get; set;
        }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            return 0;
        }
        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }
}
