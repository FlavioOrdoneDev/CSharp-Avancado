using Ducks_Example.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ducks_Example.entities
{
    public class DuckComparer : IComparer<Duck>
    {
        public SortCriteria sortBy = SortCriteria.SizeThenKind;
        
        public int Compare(Duck x, Duck y)
        {
            if (sortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                    return 1;
                else if (x.Size < y.Size)
                    return -1;
                else
                {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }   
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                {
                    if (x.Size > y.Size)
                        return 1;
                    else if (x.Size < y.Size)
                        return -1;
                    else
                        return 0;
                }                    
            }
        }
    }
}
