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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormParola_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet3.ANGAJATI);

        }
    }
}
