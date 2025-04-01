using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TPBD_proiect
{
    public partial class FormModificare : Form
    {
        string connectionString = "USER ID=STUDENT;PASSWORD=student;DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\40728\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";

        public FormModificare()
        {
            InitializeComponent();
        }

     

        private void GetProcentaje()
        {
            string query = "SELECT CAS, CASS, IMPOZIT FROM Procentaje";
            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        txtCas.Text = dt.Rows[0]["CAS"].ToString();
                        txtCass.Text = dt.Rows[0]["CASS"].ToString();
                        txtImpozit.Text = dt.Rows[0]["IMPOZIT"].ToString();

                        txtCas.Enabled = false;
                        txtCass.Enabled = false;
                        txtImpozit.Enabled = false;

                        // 🟢 Debug - să vedem dacă intră aici
                      //  MessageBox.Show("Date preluate: CAS = " + txtCas.Text + ", CASS = " + txtCass.Text + ", Impozit = " + txtImpozit.Text, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("⚠️ Nu există date în tabelul Procentaje!", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("❌ Eroare la citire: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private bool ValidatePassword(string password)
        {
            string parolaCorecta = "parolaCorecta";
            return password == parolaCorecta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = Interaction.InputBox("Introduceti parola pentru a modifica valorile:", "Autentificare", "");

            if (ValidatePassword(parola))
            {
                txtCas.Enabled = true;
                txtCass.Enabled = true;
                txtImpozit.Enabled = true;
                MessageBox.Show("Puteți acum modifica procentele.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Parola incorectă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateProcentaje(decimal cas, decimal cass, decimal impozit)
        {
            string query = @"UPDATE Procentaje SET 
                     CAS = :cas,
                     CASS = :cass,
                     IMPOZIT = :impozit";

            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add("cas", OracleDbType.Decimal).Value = cas;
                cmd.Parameters.Add("cass", OracleDbType.Decimal).Value = cass;
                cmd.Parameters.Add("impozit", OracleDbType.Decimal).Value = impozit;

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Procentele au fost actualizate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                        OracleCommand updateAngajatiCmd = new OracleCommand("UPDATE Angajati SET SALAR_BAZA = SALAR_BAZA", con);
                        updateAngajatiCmd.ExecuteNonQuery();

                        GetProcentaje(); // Reîncărcăm noile valori
                    }
                    else
                    {
                      //  MessageBox.Show("Nu s-au efectuat modificări!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Eroare la actualizare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cas = Convert.ToDecimal(txtCas.Text);
                decimal cass = Convert.ToDecimal(txtCass.Text);
                decimal impozit = Convert.ToDecimal(txtImpozit.Text);

                UpdateProcentaje(cas, cass, impozit);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valori incorecte introduse.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificaProcent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vă rugăm să selectați un rând pentru a modifica procentele.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            decimal noulCAS = Convert.ToDecimal(selectedRow.Cells["CAS"].Value);
            decimal noulCASS = Convert.ToDecimal(selectedRow.Cells["CASS"].Value);
            decimal noulImpozit = Convert.ToDecimal(selectedRow.Cells["IMPOZIT"].Value);

            txtCas.Text = noulCAS.ToString();
            txtCass.Text = noulCASS.ToString();
            txtImpozit.Text = noulImpozit.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form1 = new Form2();
            form1.Show();
        }

        private void FormModificare_Load_1(object sender, EventArgs e)
        {
            GetProcentaje();
        }
    }
}
