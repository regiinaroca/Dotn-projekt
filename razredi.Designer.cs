namespace dotn_projekt
{
    partial class razredi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.razrediDataSet = new dotn_projekt.razrediDataSet();
            this.razodjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raz_odjelTableAdapter = new dotn_projekt.razrediDataSetTableAdapters.raz_odjelTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odjelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nastavnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razodjelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.odjelDataGridViewTextBoxColumn,
            this.nastavnikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.razodjelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // razrediDataSet
            // 
            this.razrediDataSet.DataSetName = "razrediDataSet";
            this.razrediDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // razodjelBindingSource
            // 
            this.razodjelBindingSource.DataMember = "raz_odjel";
            this.razodjelBindingSource.DataSource = this.razrediDataSet;
            // 
            // raz_odjelTableAdapter
            // 
            this.raz_odjelTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odjelDataGridViewTextBoxColumn
            // 
            this.odjelDataGridViewTextBoxColumn.DataPropertyName = "odjel";
            this.odjelDataGridViewTextBoxColumn.HeaderText = "odjel";
            this.odjelDataGridViewTextBoxColumn.Name = "odjelDataGridViewTextBoxColumn";
            // 
            // nastavnikDataGridViewTextBoxColumn
            // 
            this.nastavnikDataGridViewTextBoxColumn.DataPropertyName = "nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.HeaderText = "nastavnik";
            this.nastavnikDataGridViewTextBoxColumn.Name = "nastavnikDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAZREDNI ODJELI";
            // 
            // razredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "razredi";
            this.Text = "razredi";
            this.Load += new System.EventHandler(this.razredi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razodjelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private razrediDataSet razrediDataSet;
        private System.Windows.Forms.BindingSource razodjelBindingSource;
        private razrediDataSetTableAdapters.raz_odjelTableAdapter raz_odjelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odjelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nastavnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}