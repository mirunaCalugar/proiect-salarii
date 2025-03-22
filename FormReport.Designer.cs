namespace TPBD_proiect
{
    partial class FormReport
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet3 = new TPBD_proiect.DataSet3();
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
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wfToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // wfToolStripMenuItem1
            // 
            this.wfToolStripMenuItem1.Name = "wfToolStripMenuItem1";
            this.wfToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.wfToolStripMenuItem1.Text = "wf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(387, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNGAJATIBindingSource
            // 
            this.aNGAJATIBindingSource.DataMember = "ANGAJATI";
            this.aNGAJATIBindingSource.DataSource = this.dataSet3;
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
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormReport";
            this.Text = "FormParola";
            this.Load += new System.EventHandler(this.FormParola_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNGAJATIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wfToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet3 dataSet3;
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
    }
}