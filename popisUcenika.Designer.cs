﻿namespace dotn_projekt
{
    partial class popisUcenika
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.razodjelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razrediDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.razrediDataSet1 = new dotn_projekt.razrediDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucenikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.raz_odjelTableAdapter = new dotn_projekt.razrediDataSet1TableAdapters.raz_odjelTableAdapter();
            this.ucenikTableAdapter = new dotn_projekt.razrediDataSet1TableAdapters.ucenikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.razodjelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "POPIS UČENIKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtriraj po razrednom odjelu:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.razodjelBindingSource, "id", true));
            this.comboBox1.DataSource = this.razodjelBindingSource;
            this.comboBox1.DisplayMember = "odjel";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // razodjelBindingSource
            // 
            this.razodjelBindingSource.DataMember = "raz_odjel";
            this.razodjelBindingSource.DataSource = this.razrediDataSet1BindingSource;
            // 
            // razrediDataSet1BindingSource
            // 
            this.razrediDataSet1BindingSource.DataSource = this.razrediDataSet1;
            this.razrediDataSet1BindingSource.Position = 0;
            // 
            // razrediDataSet1
            // 
            this.razrediDataSet1.DataSetName = "razrediDataSet1";
            this.razrediDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 213);
            this.dataGridView1.TabIndex = 3;
            // 
            // ucenikBindingSource
            // 
            this.ucenikBindingSource.DataMember = "ucenik";
            this.ucenikBindingSource.DataSource = this.razrediDataSet1BindingSource;
            this.ucenikBindingSource.CurrentChanged += new System.EventHandler(this.ucenikBindingSource_CurrentChanged);
            // 
            // ucenikBindingSource1
            // 
            this.ucenikBindingSource1.DataMember = "ucenik";
            this.ucenikBindingSource1.DataSource = this.razrediDataSet1BindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resetiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Izvezi u excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // raz_odjelTableAdapter
            // 
            this.raz_odjelTableAdapter.ClearBeforeFill = true;
            // 
            // ucenikTableAdapter
            // 
            this.ucenikTableAdapter.ClearBeforeFill = true;
            // 
            // popisUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "popisUcenika";
            this.Text = "popisUcenika";
            this.Load += new System.EventHandler(this.popisUcenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.razodjelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razrediDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucenikBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource razrediDataSet1BindingSource;
        private razrediDataSet1 razrediDataSet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource razodjelBindingSource;
        private razrediDataSet1TableAdapters.raz_odjelTableAdapter raz_odjelTableAdapter;
        private System.Windows.Forms.BindingSource ucenikBindingSource;
        private razrediDataSet1TableAdapters.ucenikTableAdapter ucenikTableAdapter;
        private System.Windows.Forms.BindingSource ucenikBindingSource1;
    }
}