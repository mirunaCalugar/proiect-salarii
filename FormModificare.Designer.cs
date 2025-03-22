namespace TPBD_proiect
{
    partial class FormModificare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.CAS = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCas = new System.Windows.Forms.TextBox();
            this.txtCass = new System.Windows.Forms.TextBox();
            this.txtImpozit = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet31 = new TPBD_proiect.DataSet3();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTAJETableAdapter1 = new TPBD_proiect.DataSet3TableAdapters.PROCENTAJETableAdapter();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "MODIFICARE PROCENTE";
            // 
            // CAS
            // 
            this.CAS.AutoSize = true;
            this.CAS.Location = new System.Drawing.Point(101, 78);
            this.CAS.Name = "CAS";
            this.CAS.Size = new System.Drawing.Size(34, 16);
            this.CAS.TabIndex = 1;
            this.CAS.Text = "CAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "CASS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "IMPOZIT";
            // 
            // txtCas
            // 
            this.txtCas.Location = new System.Drawing.Point(161, 78);
            this.txtCas.Name = "txtCas";
            this.txtCas.Size = new System.Drawing.Size(100, 22);
            this.txtCas.TabIndex = 4;
            // 
            // txtCass
            // 
            this.txtCass.Location = new System.Drawing.Point(161, 128);
            this.txtCass.Name = "txtCass";
            this.txtCass.Size = new System.Drawing.Size(100, 22);
            this.txtCass.TabIndex = 5;
            // 
            // txtImpozit
            // 
            this.txtImpozit.Location = new System.Drawing.Point(161, 174);
            this.txtImpozit.Name = "txtImpozit";
            this.txtImpozit.Size = new System.Drawing.Size(100, 22);
            this.txtImpozit.TabIndex = 6;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "PROCENTAJE";
            this.bindingSource2.DataSource = this.dataSet31;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet3";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PROCENTAJE";
            this.bindingSource1.DataSource = this.dataSet31;
            // 
            // pROCENTAJETableAdapter1
            // 
            this.pROCENTAJETableAdapter1.ClearBeforeFill = true;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnModifica.Location = new System.Drawing.Point(42, 245);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(108, 23);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modificare";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveChanges.Location = new System.Drawing.Point(171, 245);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(108, 23);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Salvare";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(414, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CAS";
            this.dataGridViewTextBoxColumn1.HeaderText = "CAS";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CASS";
            this.dataGridViewTextBoxColumn2.HeaderText = "CASS";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IMPOZIT";
            this.dataGridViewTextBoxColumn3.HeaderText = "IMPOZIT";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PAROLA_HASH";
            this.dataGridViewTextBoxColumn4.HeaderText = "PAROLA_HASH";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormModificare
            // 
            this.ClientSize = new System.Drawing.Size(834, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtImpozit);
            this.Controls.Add(this.txtCass);
            this.Controls.Add(this.txtCas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CAS);
            this.Controls.Add(this.label5);
            this.Name = "FormModificare";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource pROCENTAJEBindingSource;
        private DataSet3TableAdapters.PROCENTAJETableAdapter pROCENTAJETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAROLAHASHDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModificaProcent;
        private System.Windows.Forms.MaskedTextBox txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CAS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCas;
        private System.Windows.Forms.TextBox txtCass;
        private System.Windows.Forms.TextBox txtImpozit;
        private DataSet3 dataSet31;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet3TableAdapters.PROCENTAJETableAdapter pROCENTAJETableAdapter1;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}