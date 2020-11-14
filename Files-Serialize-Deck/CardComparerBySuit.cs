using System.Collections.Generic;

namespace Files_Serialize_Deck
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
                if (x.Values > y.Values)
                    return 1;
                else if (x.Values < y.Values)
                    return -1;
                else
                    return 0;
        }
    }
}
