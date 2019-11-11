using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_V1.Algorithm
{
    public class Apriori
    {
        private Dictionary<string, List<Itemset>> _fSet;
        private List<Itemset> _lSet;
        private double _support;
        AprioriTID_UI _UI;

        public AprioriTID_UI UI { get => _UI; set => _UI = value; }

        public Apriori(Dictionary<string, List<Itemset>> fSet, List<Itemset> lSet, double support)
        {
            _fSet = fSet;
            _lSet = lSet;
            _support = support * fSet.Count / 100;

            _UI = new AprioriTID_UI();
            _UI.GetLiFSet().Add(_fSet);
            _UI.GetLiLSet().Add(_lSet);
        }

        public List<Itemset> AprioriGen(List<Itemset> lSetkPre)
        {
            int length = lSetkPre.Count;
            List<Itemset> result = new List<Itemset>();
            Itemset itemset;
            List<int> item;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {

                    bool check = false;

                    for (int ind = 0; ind < lSetkPre[i].Item.Count - 1; ind++)
                    {
                        if (lSetkPre[i].Item[ind] != lSetkPre[j].Item[ind])
                        {
                            check = true;
                            break;
                        }
                    }

                    if (check)
                    {
                        continue;
                    }

                   
               
                    item = new List<int>();
                    item.AddRange(lSetkPre[i].Item);
                    item = item.Union(lSetkPre[j].Item).ToList();

                    if (item.Count > 2)
                    {
                        List<List<int>> liSupKMinusOne = Gen(item);

                        foreach (var itemKMinusOne in liSupKMinusOne)
                        {
                            if (!CheckExists(itemKMinusOne))
                            {
                                check = true;
                                break;
                            }
                        }

                        if (check)
                        {
                            continue;
                        }
                    }

                    itemset = new Itemset();
                    itemset.Item = item;
                    result.Add(itemset);
                }
            }

            return result.Count > 0 ? result : null;
        }

        public bool CheckExists(List<int> item)
        {
            List<Itemset> kSetMinusOne = _UI.GetLiLSet()[_UI.GetLiLSet().Count() - 1];
            int length = kSetMinusOne.Count();

            for (int i = 0; i < length; i++)
            {
                if (kSetMinusOne[i].Item.SequenceEqual(item)) 
                {
                    return true;
                }
            }

            return false;
        }

        public static List<List<int>> Gen(List<int> itemset)
        {
            List<List<int>> result = new List<List<int>>();
            List<int> item;

            int length = itemset.Count;

            for (int i = 0; i < length; i++)
            {
                item = new List<int>();
                for (int j = 0; j < length; j++)
                {
                    if (i != j)
                    {
                        item.Add(itemset[j]);
                    }
                }
                result.Add(item);
            }

            return result;
        }

        public List<Itemset> TID()
        {
            List<Itemset> C = AprioriGen(_lSet);
            List<Itemset> cT = null;
            Dictionary<string, List<Itemset>> F = null;
            Dictionary<string, List<Itemset>> fK = null;

            List<Itemset> L = null;
            List<Itemset> LResult = new List<Itemset>();

            while (C != null)
            {
                F = _UI.GetLiFSet()[_UI.GetLiFSet().Count() - 1];
                fK = new Dictionary<string, List<Itemset>>();

                foreach (var item in F)
                {
                    cT = AprioriGen(item.Value);
                    if (cT != null)
                    {
                        foreach (var supItemC in C)
                        {
                            foreach (var supItemCT in cT)
                            {
                                if (supItemC.Item.SequenceEqual(supItemCT.Item))
                                {
                                    supItemC.Support++;
                                }
                            }
                        }

                        fK.Add(item.Key, cT);
                    }
                }

                if (fK.Count() == 0)
                {
                    break;
                }

                L = CheckMinSupport(C);

                if (L == null)
                {
                    break;
                }

                LResult.AddRange(L);
                _UI.GetLiLSet().Add(L);
                _UI.GetLiFSet().Add(fK);

                C = AprioriGen(L);
            }

            return LResult.Count() > 0 ? LResult : null;
        }

        private List<Itemset> CheckMinSupport(List<Itemset> c)
        {
            List<Itemset> liResult = new List<Itemset>();

            foreach (var item in c)
            {
                if (item.Support >= _support)
                {
                    liResult.Add(item);
                } 
            }

            return liResult.Count() > 0 ? liResult : null;
        }
    }
}
