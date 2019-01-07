using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        int[] sayilar = { -9, -6, -5, -3, 8, 12, 25 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();

            isimler.Add("Merve");
            isimler.Add("Rojda");
            isimler.Add("Sümeyra");
            isimler.Add("Tuğba");
            isimler.Add("Ezgi");
            isimler.Add("Büşra");
            isimler.Add("Eylül");
            isimler.Add("Gamze");
            isimler.Add("Erdem");
        }

        private void button1_Click(object sender, EventArgs e)
        {


            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var n = sayilar.Where(birsey => birsey < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p = sayilar.Where(x => x > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = p.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var c = sayilar.Where(x => x % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = c.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var t = sayilar.Where(x => x % 2 != 0);
            listBox1.DataSource = null;
            listBox1.DataSource = t.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ebs = sayilar.Max();
            MessageBox.Show(ebs.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int eks = sayilar.Min();
            MessageBox.Show(eks.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int KacTane = sayilar.Length;// Daha hızlı işlem yaptığı için bunu tercih ediyoruz.
            //int KacTane1 = sayilar.Count();
            MessageBox.Show(KacTane.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var Sirala = isimler.OrderBy(x => x);
            listBox1.DataSource = Sirala.ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var TersSirala = isimler.OrderByDescending(x => x);
            listBox1.DataSource = TersSirala.ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var Uzunluk = isimler.Select(x => x.Length);
            listBox1.DataSource = Uzunluk.ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var UBarındıranlar = isimler.Where(x => x.Contains('ü'));
            listBox1.DataSource = UBarındıranlar.ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            var EIlebaslayanlar = isimler.Where(x => x.StartsWith("E"));
            listBox1.DataSource = EIlebaslayanlar.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<ORDER> orders = new ORDER().GetOrders();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<ORDER> OrdarDate = new ORDER().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OrdarDate.Select(x => new { Tarih = x.OrderDate }).ToList();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            List<ORDER> Ilk5 = new ORDER().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Ilk5.Take(5).ToList();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            List<ORDER> Son5 = new ORDER().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Son5.OrderByDescending(x => x.OrderID)
                .Take(5)
                .Select(x => new
                {
                    x.OrderID,
                    x.Customer.CustomerID,
                    x.OrderDate
                })
                    .ToList();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<ORDER> YangWang = new ORDER().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = YangWang.Where(x => x.Customer.ContactName == "Yang Wang")
                .Select(x => new
                {
                    x.OrderID,
                    x.Customer.CustomerID,
                    x.OrderDate
                })
                .ToList();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            List<ORDER> SiparisSayisi = new ORDER().GetOrders();
            
            MessageBox.Show(SiparisSayisi.Count().ToString());
        }
    }
}
