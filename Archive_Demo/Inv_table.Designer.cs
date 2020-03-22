namespace Archive_Demo
{
    partial class Inv_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inv_table));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Registration_back = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iPSArchiveDataSet = new Archive_Demo.IPSArchiveDataSet();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.InventoryTableAdapter();
            this.invIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invLitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invVolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1244, 49);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Registration_back);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 45);
            this.panel3.TabIndex = 19;
            // 
            // Registration_back
            // 
            this.Registration_back.AutoSize = true;
            this.Registration_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration_back.Location = new System.Drawing.Point(41, 12);
            this.Registration_back.Name = "Registration_back";
            this.Registration_back.Size = new System.Drawing.Size(74, 25);
            this.Registration_back.TabIndex = 1;
            this.Registration_back.Text = "Назад";
            this.Registration_back.Click += new System.EventHandler(this.Registration_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1244, 49);
            this.label16.TabIndex = 0;
            this.label16.Text = "Описи";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invIDDataGridViewTextBoxColumn,
            this.fundIDDataGridViewTextBoxColumn,
            this.invNumDataGridViewTextBoxColumn,
            this.invLitDataGridViewTextBoxColumn,
            this.invVolDataGridViewTextBoxColumn,
            this.invNameDataGridViewTextBoxColumn,
            this.yearStDataGridViewTextBoxColumn,
            this.yearEndDataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.unitCountDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 398);
            this.dataGridView1.TabIndex = 20;
            // 
            // iPSArchiveDataSet
            // 
            this.iPSArchiveDataSet.DataSetName = "IPSArchiveDataSet";
            this.iPSArchiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.iPSArchiveDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // invIDDataGridViewTextBoxColumn
            // 
            this.invIDDataGridViewTextBoxColumn.DataPropertyName = "Inv_ID";
            this.invIDDataGridViewTextBoxColumn.HeaderText = "Inv_ID";
            this.invIDDataGridViewTextBoxColumn.Name = "invIDDataGridViewTextBoxColumn";
            this.invIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fundIDDataGridViewTextBoxColumn
            // 
            this.fundIDDataGridViewTextBoxColumn.DataPropertyName = "Fund_ID";
            this.fundIDDataGridViewTextBoxColumn.HeaderText = "Fund_ID";
            this.fundIDDataGridViewTextBoxColumn.Name = "fundIDDataGridViewTextBoxColumn";
            // 
            // invNumDataGridViewTextBoxColumn
            // 
            this.invNumDataGridViewTextBoxColumn.DataPropertyName = "Inv_Num";
            this.invNumDataGridViewTextBoxColumn.HeaderText = "Inv_Num";
            this.invNumDataGridViewTextBoxColumn.Name = "invNumDataGridViewTextBoxColumn";
            // 
            // invLitDataGridViewTextBoxColumn
            // 
            this.invLitDataGridViewTextBoxColumn.DataPropertyName = "Inv_Lit";
            this.invLitDataGridViewTextBoxColumn.HeaderText = "Inv_Lit";
            this.invLitDataGridViewTextBoxColumn.Name = "invLitDataGridViewTextBoxColumn";
            // 
            // invVolDataGridViewTextBoxColumn
            // 
            this.invVolDataGridViewTextBoxColumn.DataPropertyName = "Inv_Vol";
            this.invVolDataGridViewTextBoxColumn.HeaderText = "Inv_Vol";
            this.invVolDataGridViewTextBoxColumn.Name = "invVolDataGridViewTextBoxColumn";
            // 
            // invNameDataGridViewTextBoxColumn
            // 
            this.invNameDataGridViewTextBoxColumn.DataPropertyName = "Inv_Name";
            this.invNameDataGridViewTextBoxColumn.HeaderText = "Inv_Name";
            this.invNameDataGridViewTextBoxColumn.Name = "invNameDataGridViewTextBoxColumn";
            // 
            // yearStDataGridViewTextBoxColumn
            // 
            this.yearStDataGridViewTextBoxColumn.DataPropertyName = "Year_St";
            this.yearStDataGridViewTextBoxColumn.HeaderText = "Year_St";
            this.yearStDataGridViewTextBoxColumn.Name = "yearStDataGridViewTextBoxColumn";
            // 
            // yearEndDataGridViewTextBoxColumn
            // 
            this.yearEndDataGridViewTextBoxColumn.DataPropertyName = "Year_End";
            this.yearEndDataGridViewTextBoxColumn.HeaderText = "Year_End";
            this.yearEndDataGridViewTextBoxColumn.Name = "yearEndDataGridViewTextBoxColumn";
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "Dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Dates";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            // 
            // unitCountDataGridViewTextBoxColumn
            // 
            this.unitCountDataGridViewTextBoxColumn.DataPropertyName = "Unit_Count";
            this.unitCountDataGridViewTextBoxColumn.HeaderText = "Unit_Count";
            this.unitCountDataGridViewTextBoxColumn.Name = "unitCountDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // Inv_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "Inv_table";
            this.Text = "Inv_table";
            this.Load += new System.EventHandler(this.Inv_table_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Registration_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IPSArchiveDataSet iPSArchiveDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private IPSArchiveDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invLitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invVolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}