using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhacNhapKhacXuat
{
    public partial class Form1 : Form
    {
        List<ListViewItem> arrayItems = new List<ListViewItem>();
        List<ListViewItem> arrayItems2 = new List<ListViewItem>();
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(i);
            arrayItems.Add(new ListViewItem(new[] {a,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text}));
            arrayItems2.Add(new ListViewItem(new[] { a, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text }));
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            for (int z = 0; z < i-1; z++)
            {
                listView1.Items.Add(arrayItems[z]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            for (int z = 0; z < i - 1; z++)
            {
                int year = Convert.ToInt32(arrayItems2[z].SubItems[4].Text);
                if (year < 2000)
                {
                    listView2.Items.Add(arrayItems2[z]);
                }
                else continue;
            }
        }
        string c;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem checkedItem in listView1.CheckedItems)
            {
                c += checkedItem.SubItems[2].Text + ", ";
            }
            MessageBox.Show("Các sản phẩm được chọn là: " + c);
        }


    }
}
