namespace TPBD_proiect
{
    partial class FormActualizare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CautareBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtSalarBaza = new System.Windows.Forms.TextBox();
            this.txtSpor = new System.Windows.Forms.TextBox();
            this.txtPremii = new System.Windows.Forms.TextBox();
            this.txtRetineri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet3 = new TPBD_proiect.DataSet3();
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSterge = new System.Windows.Forms.Button();
            this.aNGAJATIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNGAJATITableAdapter = new TPBD_proiect.DataSet3TableAdapters.ANGAJATITableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCTIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALARBAZADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREMIIBRUTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETINERIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALBRUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bRUTIMPOZABILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMPOZITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIRATCARDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.pROCENTAJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCENTAJETableAdapter = new TPBD_proiect.DataSet3TableAdapters.PROCENTAJETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTUALIZARE ANGAJAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cautare angajat";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // CautareBtn
            // 
            this.CautareBtn.Location = new System.Drawing.Point(452, 76);
            this.CautareBtn.Name = "CautareBtn";
            this.CautareBtn.Size = new System.Drawing.Size(75, 23);
            this.CautareBtn.TabIndex = 3;
            this.CautareBtn.Text = "Cautare";
            this.CautareBtn.UseVisualStyleBackColor = true;
            this.CautareBtn.Click += new System.EventHandler(this.CautareBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenume";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salariu Baza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Spor (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Premii Brute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Retineri";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(128, 118);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 10;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(128, 158);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(100, 22);
            this.txtPrenume.TabIndex = 11;
            // 
            // txtSalarBaza
            // 
            this.txtSalarBaza.Location = new System.Drawing.Point(128, 195);
            this.txtSalarBaza.Name = "txtSalarBaza";
            this.txtSalarBaza.Size = new System.Drawing.Size(100, 22);
            this.txtSalarBaza.TabIndex = 12;
            // 
            // txtSpor
            // 
            this.txtSpor.Location = new System.Drawing.Point(128, 230);
            this.txtSpor.Name = "txtSpor";
            this.txtSpor.Size = new System.Drawing.Size(100, 22);
            this.txtSpor.TabIndex = 13;
            // 
            // txtPremii
            // 
            this.txtPremii.Location = new System.Drawing.Point(128, 273);
            this.txtPremii.Name = "txtPremii";
            this.txtPremii.Size = new System.Drawing.Size(100, 22);
            this.txtPremii.TabIndex = 14;
            // 
            // txtRetineri
            // 
            this.txtRetineri.Location = new System.Drawing.Point(128, 312);
            this.txtRetineri.Name = "txtRetineri";
            this.txtRetineri.Size = new System.Drawing.Size(100, 22);
            this.txtRetineri.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(39, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Actualizare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nUMEDataGridViewTextBoxColumn,
            this.pRENUMEDataGridViewTextBoxColumn,
            this.fUNCTIEDataGridViewTextBoxColumn,
            this.sALARBAZADataGridViewTextBoxColumn,
            this.sPORDataGridViewTextBoxColumn,
            this.pREMIIBRUTEDataGridViewTextBoxColumn,
            this.rETINERIDataGridViewTextBoxColumn,
            this.tOTALBRUTDataGridViewTextBoxColumn,
            this.bRUTIMPOZABILDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.iMPOZITDataGridViewTextBoxColumn,
            this.vIRATCARDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aNGAJATIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(351, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 259);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.IndianRed;
            this.btnSterge.Location = new System.Drawing.Point(157, 370);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(100, 23);
            this.btnSterge.TabIndex = 18;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // aNGAJATIBindingSource
            // 
            this.aNGAJATIBindingSource.DataMember = "ANGAJATI";
            this.aNGAJATIBindingSource.DataSource = this.dataSet3BindingSource;
            // 
            // aNGAJATITableAdapter
            // 
            this.aNGAJATITableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nUMEDataGridViewTextBoxColumn
            // 
            this.nUMEDataGridViewTextBoxColumn.DataPropertyName = "NUME";
            this.nUMEDataGridViewTextBoxColumn.HeaderText = "NUME";
            this.nUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nUMEDataGridViewTextBoxColumn.Name = "nUMEDataGridViewTextBoxColumn";
            this.nUMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pRENUMEDataGridViewTextBoxColumn
            // 
            this.pRENUMEDataGridViewTextBoxColumn.DataPropertyName = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.HeaderText = "PRENUME";
            this.pRENUMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRENUMEDataGridViewTextBoxColumn.Name = "pRENUMEDataGridViewTextBoxColumn";
            this.pRENUMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // fUNCTIEDataGridViewTextBoxColumn
            // 
            this.fUNCTIEDataGridViewTextBoxColumn.DataPropertyName = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.HeaderText = "FUNCTIE";
            this.fUNCTIEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fUNCTIEDataGridViewTextBoxColumn.Name = "fUNCTIEDataGridViewTextBoxColumn";
            this.fUNCTIEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sALARBAZADataGridViewTextBoxColumn
            // 
            this.sALARBAZADataGridViewTextBoxColumn.DataPropertyName = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.HeaderText = "SALAR_BAZA";
            this.sALARBAZADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sALARBAZADataGridViewTextBoxColumn.Name = "sALARBAZADataGridViewTextBoxColumn";
            this.sALARBAZADataGridViewTextBoxColumn.Width = 125;
            // 
            // sPORDataGridViewTextBoxColumn
            // 
            this.sPORDataGridViewTextBoxColumn.DataPropertyName = "SPOR";
            this.sPORDataGridViewTextBoxColumn.HeaderText = "SPOR";
            this.sPORDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sPORDataGridViewTextBoxColumn.Name = "sPORDataGridViewTextBoxColumn";
            this.sPORDataGridViewTextBoxColumn.Width = 125;
            // 
            // pREMIIBRUTEDataGridViewTextBoxColumn
            // 
            this.pREMIIBRUTEDataGridViewTextBoxColumn.DataPropertyName = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.HeaderText = "PREMII_BRUTE";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pREMIIBRUTEDataGridViewTextBoxColumn.Name = "pREMIIBRUTEDataGridViewTextBoxColumn";
            this.pREMIIBRUTEDataGridViewTextBoxColumn.Width = 125;
            // 
            // rETINERIDataGridViewTextBoxColumn
            // 
            this.rETINERIDataGridViewTextBoxColumn.DataPropertyName = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.HeaderText = "RETINERI";
            this.rETINERIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rETINERIDataGridViewTextBoxColumn.Name = "rETINERIDataGridViewTextBoxColumn";
            this.rETINERIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tOTALBRUTDataGridViewTextBoxColumn
            // 
            this.tOTALBRUTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.HeaderText = "TOTAL_BRUT";
            this.tOTALBRUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOTALBRUTDataGridViewTextBoxColumn.Name = "tOTALBRUTDataGridViewTextBoxColumn";
            this.tOTALBRUTDataGridViewTextBoxColumn.Width = 125;
            // 
            // bRUTIMPOZABILDataGridViewTextBoxColumn
            // 
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.DataPropertyName = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.HeaderText = "BRUT_IMPOZABIL";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.Name = "bRUTIMPOZABILDataGridViewTextBoxColumn";
            this.bRUTIMPOZABILDataGridViewTextBoxColumn.Width = 125;
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            this.cASDataGridViewTextBoxColumn.Width = 125;
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            this.cASSDataGridViewTextBoxColumn.Width = 125;
            // 
            // iMPOZITDataGridViewTextBoxColumn
            // 
            this.iMPOZITDataGridViewTextBoxColumn.DataPropertyName = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.HeaderText = "IMPOZIT";
            this.iMPOZITDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iMPOZITDataGridViewTextBoxColumn.Name = "iMPOZITDataGridViewTextBoxColumn";
            this.iMPOZITDataGridViewTextBoxColumn.Width = 125;
            // 
            // vIRATCARDDataGridViewTextBoxColumn
            // 
            this.vIRATCARDDataGridViewTextBoxColumn.DataPropertyName = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.HeaderText = "VIRAT_CARD";
            this.vIRATCARDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vIRATCARDDataGridViewTextBoxColumn.Name = "vIRATCARDDataGridViewTextBoxColumn";
            this.vIRATCARDDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(12, 12);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(75, 23);
            this.btnInapoi.TabIndex = 19;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // pROCENTAJEBindingSource
            // 
            this.pROCENTAJEBindingSource.DataMember = "PROCENTAJE";
            this.pROCENTAJEBindingSource.DataSource = this.dataSet3BindingSource;
            // 
            // pROCENTAJETableAdapter
            // 
            this.pROCENTAJETableAdapter.ClearBeforeFill = true;
            // 
            // FormActualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRetineri);
            this.Controls.Add(this.txtPremii);
            this.Controls.Add(this.txtSpor);
            this.Controls.Add(this.txtSalarBaza);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CautareBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormActualizare";
            this.Text = "FormActualizare";
            this.Load += new System.EventHandler(this.FormActualizare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCENTAJEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button CautareBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtSalarBaza;
        private System.Windows.Forms.TextBox txtSpor;
        private System.Windows.Forms.TextBox txtPremii;
        private System.Windows.Forms.TextBox txtRetineri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.BindingSource aNGAJATIBindingSource;
        private DataSet3TableAdapters.ANGAJATITableAdapter aNGAJATITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fUNCTIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARBAZADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREMIIBRUTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETINERIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALBRUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRUTIMPOZABILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMPOZITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vIRATCARDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.BindingSource pROCENTAJEBindingSource;
        private DataSet3TableAdapters.PROCENTAJETableAdapter pROCENTAJETableAdapter;
    }
}