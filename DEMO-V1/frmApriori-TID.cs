using DEMO_V1.Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_V1
{
    public partial class frmApriori_TID : Form
    {

        #region global variable
        int step = 0;
        int maxStep = 0;
        Apriori apriori = null;
        #endregion

        public frmApriori_TID()
        {
            InitializeComponent();
        }

        public frmApriori_TID(ListView lsvD, int minsup, ListHeader listHeader)
        {
            InitializeComponent();
            
            //========================= LISTVIEW DEFINE
            lsvF.FullRowSelect = true;
            lsvF.View = View.Details;
            lsvF.Columns.Add("Mã Sinh Viên");
            lsvF.Columns.Add("Ứng Viên");

            lsvC.FullRowSelect = true;
            lsvC.View = View.Details;
            lsvC.Columns.Add("Ứng viên");
            lsvC.Columns.Add("Support");

            //=========================


            int idx = 0;
            List<Itemset> labels = new List<Itemset>();

            foreach (ColumnHeader item in lsvD.Columns)
            {
                if (idx == 0)
                {
                    idx++;
                    continue;
                }

                Header header = listHeader.Headers.FirstOrDefault(p => p.MAMH == item.Text);
                labels.Add(new Itemset(new List<int>() { header.Code }, 0));

                idx++;
            }

            Dictionary<string, List<Itemset>> data = new Dictionary<string, List<Itemset>>();
            string key = "";
            List<Itemset> liItemset = null;
            Itemset itemset = null;

            for (int i = 0; i < lsvD.Items.Count; i++)
            {
                idx = -1;
                liItemset = new List<Itemset>();
                
                key = "";

                foreach (ListViewItem.ListViewSubItem item in lsvD.Items[i].SubItems)
                {
                    if (idx == -1)
                    {
                        key = item.Text;
                        idx++;
                        continue;
                    }

                    if (int.Parse(item.Text) == 1)
                    {
                        itemset = new Itemset();

                        itemset.Item.Add(labels[idx].Item[0]);
                        liItemset.Add(itemset);
                        labels[idx].Support++;
                        
                    }

                    idx++;
                }
                data.Add(key, liItemset);
            }
            apriori = new Apriori(data, labels, minsup);
            var L = apriori.TID();
            maxStep = apriori.UI.GetLiLSet().Count - 1;

            ShowF(apriori.UI.GetLiFSet()[step]);
            ShowC(apriori.UI.GetLiLSet()[step]);
        }

        public void ShowF(Dictionary<string, List<Itemset>> fSet)
        {
            lsvF.Items.Clear();
            string txt = "";
            foreach (var data in fSet)
            {
                ListViewItem item = new ListViewItem() { Text = data.Key };
                txt = "";

                foreach (var itemset in data.Value)
                {
                    txt += "{" + string.Join(",", itemset.Item) + "} ";
                }

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = txt });
                lsvF.Items.Add(item);
            }
            lsvF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void ShowC(List<Itemset> cSet)
        {
            lsvC.Items.Clear();
            foreach (var itemset in cSet)
            {
                ListViewItem item = new ListViewItem() { Text = string.Join(",", itemset.Item) };

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = itemset.Support.ToString() });
                lsvC.Items.Add(item);

            }
            lsvC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvC.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            step++;
            btnPre.Enabled = true;
            if (step >= maxStep)
            {
                btnNext.Enabled = false;
            } 

            ShowF(apriori.UI.GetLiFSet()[step]);
            ShowC(apriori.UI.GetLiLSet()[step]);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            step--;
            btnNext.Enabled = true;
            if (step <= 0)
            {
                btnPre.Enabled = false;
            }

            ShowF(apriori.UI.GetLiFSet()[step]);
            ShowC(apriori.UI.GetLiLSet()[step]);
        }
    }
}
