using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngusu_3__1359
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            int sayi = Convert.ToInt32(txtSayi.Text);
            for(int i = 1; i <= sayi; i++)
            {
                lbSayilar.Items.Add(i);
            }    
        }
    }
}
