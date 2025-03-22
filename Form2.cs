using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPBD_proiect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormActualizare form1 = new FormActualizare();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormActualizare form1 = new FormActualizare();
            form1.Show();
        }

        private void dateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormActualizare form1 = new FormActualizare();
            form1.Show();
        }

        private void modificareButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModificare form1 = new FormModificare();
            form1.Show();
        }
    }
}
