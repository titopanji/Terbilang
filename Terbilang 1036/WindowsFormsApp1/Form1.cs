using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryTerbilang1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        terbilang bilang = new terbilang();


        private void button1_Click(object sender, EventArgs e)
        {
            var i = Convert.ToInt32(textBox1.Text);

            richTextBox1.Text = (Convert.ToString(bilang.TerbilangIndonesia(i)));
        }
    }
}
