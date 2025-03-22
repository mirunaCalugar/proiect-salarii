using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace TPBD_proiect
{
    public partial class Form1 : Form
    {
        // Conexiune la baza de date
        private readonly string connectionString = "USER ID=STUDENT;PASSWORD=student;DATA SOURCE=localhost:1521/XE;TNS_ADMIN=C:\\Users\\40728\\Oracle\\network\\admin;PERSIST SECURITY INFO=True";

        public Form1()
        {
            InitializeComponent();
        }

        // La încărcarea ferestrei, verifică conexiunea la BD
        private void Form1_Load(object sender, EventArgs e)
        {
            TestDatabaseConnection();
        }

        #region Conexiune BD

        private void TestDatabaseConnection()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();
                    MessageBox.Show("Conexiune reușită!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelErr.Text = "Conexiune cu succes!";
                    labelErr.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Eroare conexiune: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelErr.Text = "Conexiune eșuată!";
                labelErr.ForeColor = System.Drawing.Color.Red;
            }
        }


        #endregion

        #region Operații BD

        private void InsertEmployee(string nume, string prenume, string functie, decimal salarBaza, decimal spor, decimal premii, decimal retineri)
        {
            // Calculul salariului
            decimal totalBrut = salarBaza + (salarBaza * spor / 100) + premii;
            decimal CAS = totalBrut * 0.25m;
            decimal CASS = totalBrut * 0.10m;
            decimal brutImpozabil = totalBrut - (CAS + CASS);
            decimal impozit = brutImpozabil * 0.10m;
            decimal viratCard = brutImpozabil - impozit - retineri;

            string query = @"INSERT INTO Angajati 
                            (NUME, PRENUME, FUNCTIE, SALAR_BAZA, SPOR, PREMII_BRUTE, RETINERI, 
                             TOTAL_BRUT, BRUT_IMPOZABIL, CAS, CASS, IMPOZIT, VIRAT_CARD) 
                             VALUES 
                            (:nume, :prenume, :functie, :salarBaza, :spor, :premii, :retineri, 
                             :totalBrut, :brutImpozabil, :CAS, :CASS, :impozit, :viratCard)";

            using (OracleConnection con = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, con))
            {
                cmd.Parameters.Add("nume", OracleDbType.Varchar2).Value = nume;
                cmd.Parameters.Add("prenume", OracleDbType.Varchar2).Value = prenume;
                cmd.Parameters.Add("functie", OracleDbType.Varchar2).Value = functie;
                cmd.Parameters.Add("salarBaza", OracleDbType.Decimal).Value = salarBaza;
                cmd.Parameters.Add("spor", OracleDbType.Decimal).Value = spor;
                cmd.Parameters.Add("premii", OracleDbType.Decimal).Value = premii;
                cmd.Parameters.Add("retineri", OracleDbType.Decimal).Value = retineri;
                cmd.Parameters.Add("totalBrut", OracleDbType.Decimal).Value = totalBrut;
                cmd.Parameters.Add("brutImpozabil", OracleDbType.Decimal).Value = brutImpozabil;
                cmd.Parameters.Add("CAS", OracleDbType.Decimal).Value = CAS;
                cmd.Parameters.Add("CASS", OracleDbType.Decimal).Value = CASS;
                cmd.Parameters.Add("impozit", OracleDbType.Decimal).Value = impozit;
                cmd.Parameters.Add("viratCard", OracleDbType.Decimal).Value = viratCard;

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    labelErr.Text = $"{rowsAffected} angajat adăugat!";
                    labelErr.ForeColor = System.Drawing.Color.Green;
                }
                catch (OracleException ex)
                {
                    labelErr.Text = "Eroare la inserare: " + ex.Message;
                    labelErr.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void GetEmployees()
        {
            string query = "SELECT * FROM Angajati";
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
                    labelErr.Text = "Date încărcate cu succes!";
                    labelErr.ForeColor = System.Drawing.Color.Green;
                }
                catch (OracleException ex)
                {
                    labelErr.Text = "Eroare la citire: " + ex.Message;
                    labelErr.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        #endregion

        #region Evenimente butoane

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text) ||
                string.IsNullOrWhiteSpace(textBox8.Text) || string.IsNullOrWhiteSpace(textBox9.Text) ||
                string.IsNullOrWhiteSpace(textBox10.Text))
            {
                labelErr.Text = "Toate câmpurile sunt obligatorii!";
                labelErr.ForeColor = System.Drawing.Color.Red;
                return;
            }

            try
            {
                decimal salarBaza = Convert.ToDecimal(textBox7.Text);
                decimal spor = Convert.ToDecimal(textBox8.Text);
                decimal premii = Convert.ToDecimal(textBox9.Text);
                decimal retineri = Convert.ToDecimal(textBox10.Text);

                if (salarBaza < 0 || spor < 0 || premii < 0 || retineri < 0)
                {
                    labelErr.Text = "Valori negative nepermise!";
                    labelErr.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                InsertEmployee(textBox4.Text, textBox5.Text, textBox6.Text, salarBaza, spor, premii, retineri);
            }
            catch (FormatException ex)
            {
                labelErr.Text = "Date incorecte! " + ex.Message;
                labelErr.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetEmployees();
        }

        #endregion

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.ANGAJATI' table. You can move, or remove it, as needed.
            this.aNGAJATITableAdapter.Fill(this.dataSet3.ANGAJATI);
            this.Load += new System.EventHandler(this.Form1_Load);
           // MessageBox.Show("Form1_Load a fost apelat!", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TestDatabaseConnection();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form1 = new Form2();
            form1.Show();
        }
    }
}
