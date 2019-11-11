using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_V1.Algorithm
{
    public class AprioriTID_UI
    {
        private List<Dictionary<string, List<Itemset>>> _liFSet;
        private List<List<Itemset>> _liLSet;

        public AprioriTID_UI()
        {
            _liFSet = new List<Dictionary<string, List<Itemset>>>();
            _liLSet = new List<List<Itemset>>();
        }

        public void SetLiLSet(List<List<Itemset>> liLSet)
        {
            _liLSet = liLSet;
        }

        public List<List<Itemset>> GetLiLSet()
        {
            return _liLSet;
        }

        public void SetLiFSet(List<Dictionary<string, List<Itemset>>> liFSet)
        {
            _liFSet = liFSet;
        }

        public List<Dictionary<string, List<Itemset>>> GetLiFSet()
        {
            return _liFSet;
        }
    }
}
