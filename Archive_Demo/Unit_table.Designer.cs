namespace Archive_Demo
{
    partial class Unit_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unit_table));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Registration_back = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPSArchiveDataSet = new Archive_Demo.IPSArchiveDataSet();
            this.unitTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.UnitTableAdapter();
            this.saveBtn = new System.Windows.Forms.Button();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitLitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.unitTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(1350, 49);
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
            this.Registration_back.Location = new System.Drawing.Point(41, 8);
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
            this.label16.Size = new System.Drawing.Size(1350, 49);
            this.label16.TabIndex = 0;
            this.label16.Text = "Документы";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unitIDDataGridViewTextBoxColumn,
            this.unitNumDataGridViewTextBoxColumn,
            this.unitLitDataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.unitNameDataGridViewTextBoxColumn,
            this.pCountDataGridViewTextBoxColumn,
            this.dateCreateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.invIDDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.unitTypeDataGridViewTextBoxColumn,
            this.yearStDataGridViewTextBoxColumn,
            this.yearEndDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.unitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1350, 347);
            this.dataGridView1.TabIndex = 20;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.iPSArchiveDataSet;
            // 
            // iPSArchiveDataSet
            // 
            this.iPSArchiveDataSet.DataSetName = "IPSArchiveDataSet";
            this.iPSArchiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1263, 415);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "Unit_ID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitNumDataGridViewTextBoxColumn
            // 
            this.unitNumDataGridViewTextBoxColumn.DataPropertyName = "Unit_Num";
            this.unitNumDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.unitNumDataGridViewTextBoxColumn.Name = "unitNumDataGridViewTextBoxColumn";
            // 
            // unitLitDataGridViewTextBoxColumn
            // 
            this.unitLitDataGridViewTextBoxColumn.DataPropertyName = "Unit_Lit";
            this.unitLitDataGridViewTextBoxColumn.HeaderText = "Литерал";
            this.unitLitDataGridViewTextBoxColumn.Name = "unitLitDataGridViewTextBoxColumn";
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "Dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Период ведения";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            this.unitNameDataGridViewTextBoxColumn.DataPropertyName = "Unit_Name";
            this.unitNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // pCountDataGridViewTextBoxColumn
            // 
            this.pCountDataGridViewTextBoxColumn.DataPropertyName = "P_Count";
            this.pCountDataGridViewTextBoxColumn.HeaderText = "Кол-во документов";
            this.pCountDataGridViewTextBoxColumn.Name = "pCountDataGridViewTextBoxColumn";
            // 
            // dateCreateDataGridViewTextBoxColumn
            // 
            this.dateCreateDataGridViewTextBoxColumn.DataPropertyName = "DateCreate";
            this.dateCreateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.dateCreateDataGridViewTextBoxColumn.Name = "dateCreateDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // invIDDataGridViewTextBoxColumn
            // 
            this.invIDDataGridViewTextBoxColumn.DataPropertyName = "Inv_ID";
            this.invIDDataGridViewTextBoxColumn.HeaderText = "ID Описи";
            this.invIDDataGridViewTextBoxColumn.Name = "invIDDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Удалено";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // unitTypeDataGridViewTextBoxColumn
            // 
            this.unitTypeDataGridViewTextBoxColumn.DataPropertyName = "Unit_Type";
            this.unitTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.unitTypeDataGridViewTextBoxColumn.Name = "unitTypeDataGridViewTextBoxColumn";
            // 
            // yearStDataGridViewTextBoxColumn
            // 
            this.yearStDataGridViewTextBoxColumn.DataPropertyName = "Year_St";
            this.yearStDataGridViewTextBoxColumn.HeaderText = "Дата заведения";
            this.yearStDataGridViewTextBoxColumn.Name = "yearStDataGridViewTextBoxColumn";
            // 
            // yearEndDataGridViewTextBoxColumn
            // 
            this.yearEndDataGridViewTextBoxColumn.DataPropertyName = "Year_End";
            this.yearEndDataGridViewTextBoxColumn.HeaderText = "Дата закрытия";
            this.yearEndDataGridViewTextBoxColumn.Name = "yearEndDataGridViewTextBoxColumn";
            // 
            // Unit_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Name = "Unit_table";
            this.Text = "Unit_table";
            this.Load += new System.EventHandler(this.Unit_table_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource unitBindingSource;
        private IPSArchiveDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitLitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearEndDataGridViewTextBoxColumn;
    }
}