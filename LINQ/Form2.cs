using LINQ.Properties;
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
    public partial class Form2 : Form
    {

        internal List<Personel> liste = new List<Personel>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btn_YerelPersonel_Click(object sender, EventArgs e)
        {
            liste.Add(new Personel());
            string psayisi = liste.Count().ToString();
            lbl_PersoneSayi.Text = Resources.Sablon1.Replace("0", psayisi);


            string ort = liste.Average(x=> x.Maas).ToString();
            lbl_POM.Text = Resources.Sablon2.Replace("0",ort);

          
            string yas = liste.Last().Yas.ToString();
            lbl_Yas.Text = Resources.Sablon3.Replace("0",yas);


            string Maas = liste.Last().Maas.ToString();
            lbl_Maas.Text = Resources.Sablon4.Replace("0", Maas);

        }
    }
}
