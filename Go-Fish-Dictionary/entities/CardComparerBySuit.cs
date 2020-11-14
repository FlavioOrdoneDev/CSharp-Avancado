﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish_Dictionary.entities
{
    public class CardComparerBySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suits > y.Suits)
                return 1;
            else if (x.Suits < y.Suits)
                return -1;
            else
                return 0;            
        }
    }
}
