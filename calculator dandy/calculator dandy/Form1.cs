using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_dandy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Nilai1.Text); //proses casting
            var b = Convert.ToInt32(NilaiB.Text); //casting
            Double lstHasil;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lstHasil = a + b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 1:
                    lstHasil = a - b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 2:
                    lstHasil = a * b; 
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
                case 3:
                    lstHasil = a / b;
                    Hasil.Text = Convert.ToString(lstHasil);
                    break;
            }
        }
    }
}
 