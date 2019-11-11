using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_V1
{
    public class Itemset
    {
        List<int> item;
        double support;
        public double Support { get => support; set => support = value; }
        public List<int> Item { get => item; set => item = value; }

        public Itemset(List<int> item, double support)
        {
            this.item = item;
            this.support = support;
        }

        public Itemset()
        {
            item = new List<int>();
            support = 0;
        }

    }
}
