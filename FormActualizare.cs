using Oracle.ManagedDataAccess.Client;
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
    public partial class FormActualizare : Form
    {
        private readonly string connectionString = "USER ID=STUDENT;PASSWORD=student;DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\40728\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";
        public FormActualizare()
        {
            InitializeComponent();
        }

        private void FormActualizare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.PROCENTAJE' table. You can move, or remove it, as needed.
            this.pROCENTAJETableAdapter.Fill(this.dataSet3.PROCENTAJE);
            // TODO: This line of code loads data into the 'dataSet3.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet3.ANGAJATI);
            GetEmployees();
        }
        private void GetEmployees()
        {
            string query = "SELECT NUME, PRENUME, FUNCTIE, SALAR_BAZA, SPOR, PREMII_BRUTE, RETINERI, TOTAL_BRUT, BRUT_IMPOZABIL, CAS, CASS, IMPOZIT, VIRAT_CARD FROM Angajati";
            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            using (OracleDataAdapter da = new OracleDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                try
                {
                    con.Open();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        Console.WriteLine(col.Name); // Afișează numele coloanelor în Output (Debug)
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Eroare la citire: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Evenimentul de selectare a unui angajat din DataGridView pentru a popula câmpurile editabile
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Populam câmpurile editabile cu datele selectate din DataGridView
                txtNume.Text = row.Cells["Nume"].Value.ToString();
                txtPrenume.Text = row.Cells["Prenume"].Value.ToString();
                txtSalarBaza.Text = row.Cells["Salariu Baza"].Value.ToString();
                txtSpor.Text = row.Cells["Spor"].Value.ToString();
                txtPremii.Text = row.Cells["Premii Brute"].Value.ToString();
                txtRetineri.Text = row.Cells["Retineri"].Value.ToString();
            }
        }


        private void CautareBtn_Click(object sender, EventArgs e)
        {
            string numeAngajat = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(numeAngajat))
            {
                MessageBox.Show("Introduceti un nume pentru a cauta angajatul.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchEmployee(numeAngajat);
        }
        private void SearchEmployee(string nume)
        {
            string query = "SELECT * FROM Angajati WHERE NUME = :nume";
            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        con.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt; 
                            if (dt.Rows.Count == 1) 
                            {
                                DataRow row = dt.Rows[0];
                                txtNume.Text = row["NUME"].ToString();
                                txtPrenume.Text = row["PRENUME"].ToString();
                                txtSalarBaza.Text = row["SALAR_BAZA"].ToString();
                                txtSpor.Text = row["SPOR"].ToString();
                                txtPremii.Text = row["PREMII_BRUTE"].ToString();
                                txtRetineri.Text = row["RETINERI"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Angajatul nu a fost găsit!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetEmployees(); 
                        }
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Eroare la căutare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string prenume = txtPrenume.Text.Trim();
            decimal salarBaza = Convert.ToDecimal(txtSalarBaza.Text);
            decimal spor = Convert.ToDecimal(txtSpor.Text);
            decimal premii = Convert.ToDecimal(txtPremii.Text);
            decimal retineri = Convert.ToDecimal(txtRetineri.Text);


            if (string.IsNullOrWhiteSpace(nume) || salarBaza < 0 || spor < 0 || premii < 0 || retineri < 0)
            {
                MessageBox.Show("Completează toate câmpurile corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizare angajat
            UpdateEmployee(nume, prenume, salarBaza, spor, premii, retineri);
        }

        private void UpdateEmployee(string nume, string prenume, decimal salarBaza, decimal spor, decimal premii, decimal retineri)
        {
            string query = @"UPDATE Angajati SET 
                             SALAR_BAZA = :salarBaza,
                             SPOR = :spor,
                             PREMII_BRUTE = :premii,
                             RETINERI = :retineri
                             WHERE NUME = :nume AND PRENUME = :prenume";
            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add("salarBaza", OracleDbType.Decimal).Value = salarBaza;
                cmd.Parameters.Add("spor", OracleDbType.Decimal).Value = spor;
                cmd.Parameters.Add("premii", OracleDbType.Decimal).Value = premii;
                cmd.Parameters.Add("retineri", OracleDbType.Decimal).Value = retineri;
                cmd.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;
                cmd.Parameters.Add("prenume", OracleDbType.Varchar2).Value = prenume;
                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datele au fost actualizate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-au efectuat modificări! Verificați dacă angajatul există.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Eroare la actualizare: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNume.Text = row.Cells["nUMEDataGridViewTextBoxColumn"].Value.ToString();
                txtPrenume.Text = row.Cells["pRENUMEDataGridViewTextBoxColumn"].Value.ToString();
                txtSalarBaza.Text = row.Cells["sALARBAZADataGridViewTextBoxColumn"].Value.ToString();
                txtSpor.Text = row.Cells["sPORDataGridViewTextBoxColumn"].Value.ToString();
                txtPremii.Text = row.Cells["pREMIIBRUTEDataGridViewTextBoxColumn"].Value.ToString();
                txtRetineri.Text = row.Cells["rETINERIDataGridViewTextBoxColumn"].Value.ToString();
            }



        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Sigur doriți să ștergeți acest angajat?", "Confirmare",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string nume = dataGridView1.SelectedRows[0].Cells["nUMEDataGridViewTextBoxColumn"].Value.ToString();
                    string prenume = dataGridView1.SelectedRows[0].Cells["pRENUMEDataGridViewTextBoxColumn"].Value.ToString();

                    string query = "DELETE FROM Angajati WHERE NUME = :nume AND PRENUME = :prenume";

                    using (OracleConnection con = new OracleConnection(connectionString))
                    using (OracleCommand cmd = new OracleCommand(query, con))
                    {
                        cmd.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;
                        cmd.Parameters.Add("prenume", OracleDbType.Varchar2).Value = prenume;

                        try
                        {
                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Angajat șters cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetEmployees(); 
                            }
                            else
                            {
                                MessageBox.Show("Angajatul nu a fost găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Eroare la ștergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selectați un angajat din tabel pentru a-l șterge!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form1 = new Form2();
            form1.Show();
        }
    }
}
