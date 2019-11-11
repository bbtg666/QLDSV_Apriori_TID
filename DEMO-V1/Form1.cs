using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace DEMO_V1
{
    public partial class Form1 : Form
    {
        ListHeader listHeader = new ListHeader();

        public Form1()
        {
            InitializeComponent();
            btnItemSets.Enabled = false;
            //AllocConsole();
            lsvD.FullRowSelect = true;
            lsvD.View = View.Details;
            lsvItemsCode.FullRowSelect = true;
            lsvItemsCode.View = View.Details;
            lsvItemsCode.Columns.Add("Mã Item");
            lsvItemsCode.Columns.Add("Mã Môn Học");
        }

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        public void ShowMaHoaItem()
        {
            ListViewItem item = null;

            foreach (var header in listHeader.Headers)
            {
                item = new ListViewItem() { Text = header.Code.ToString() };
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = header.MAMH });
                lsvItemsCode.Items.Add(item);
            }

        }

        public void ShowTapD(ListView lsvD, string minsup = "1")
        {
            
            if (int.Parse(txtMinSup.Text) == int.Parse(txtPreMinSup.Text))
            {
                MessageBox.Show("Bạn chưa chọn Minsup mới!");
                return;
            }
            
            lsvD.Columns.Clear();
            lsvD.Items.Clear();
            // reset all field in listview and listheader
            lsvItemsCode.Items.Clear();
            listHeader.Remove();
            //
            txtPreMinSup.Text = txtMinSup.Text;

            Program.KetNoi();
            String strlenh = "EXEC SP_GIAOTAC " + "'" + minsup + "'";
            SqlDataReader dr;
            dr = Program.ExecSqlDataReader(strlenh);

            if (dr == null)
            {
                Program.conn.Close();
                return;
            }
            btnItemSets.Enabled = true;
            // show colomns name and show new itemcode
            lsvD.Columns.Add("MASV");
            try
            {
                Header header = null;
                int i = 0;

                while (dr.Read())
                {
                    lsvD.Columns.Add(dr.GetString(0));

                    header = new Header();
                    header.MAMH = dr.GetString(0);
                    header.Code = ++i;

                    listHeader.Headers.Add(header);
                }
                //dr.Close();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            // show record
            if (dr.NextResult())
            {
                try
                {
                    int n = dr.FieldCount;
                    ListViewItem item = null;

                    while (dr.Read())
                    {
                        item = new ListViewItem() { Text = dr.GetValue(0).ToString() };
                        for (int i = 1; i < n; i++)
                        {
                            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dr.GetValue(i).ToString() });
                        }
                        lsvD.Items.Add(item);
                    }
                    dr.Close();

                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            Program.conn.Close();

            // ListView Column Width Auto
            lsvD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvD.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);          
            lsvItemsCode.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvItemsCode.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnD_Click(object sender, EventArgs e)
        {          
            ShowTapD(lsvD, txtMinSup.Text);
            ShowMaHoaItem();
        }

        private void tbrMinSup_ValueChanged(object sender, EventArgs e)
        {
            btnItemSets.Enabled = false;
            txtMinSup.Text = tbrMinSup.Value.ToString();

            if (int.Parse(txtMinSup.Text) == int.Parse(txtPreMinSup.Text))
            {
                btnItemSets.Enabled = true;
            }

        }

        private void btnItemSets_Click(object sender, EventArgs e)
        {
            frmApriori_TID frm = new frmApriori_TID(lsvD, int.Parse(txtMinSup.Text), listHeader);
            frm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtPreMinSup.Text) == 0 || int.Parse(txtPreMinSup.Text) == tbrMinSup.Value)
            {
                return;
            }

            tbrMinSup.Value = int.Parse(txtPreMinSup.Text);
        }
    }
}
