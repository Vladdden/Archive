namespace Archive_Demo
{
    partial class Fund_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fund_table));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Registration_back = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Fund_dataGridView = new System.Windows.Forms.DataGridView();
            this.fundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundLitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearStDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPSArchiveDataSet = new Archive_Demo.IPSArchiveDataSet();
            this.fundTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.FundTableAdapter();
            this.saveBtn = new System.Windows.Forms.Button();
            this.Fund_search_btn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fund_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).BeginInit();
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
            this.panel4.Size = new System.Drawing.Size(944, 49);
            this.panel4.TabIndex = 18;
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
            this.label16.Size = new System.Drawing.Size(944, 49);
            this.label16.TabIndex = 0;
            this.label16.Text = "Фонды";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fund_dataGridView
            // 
            this.Fund_dataGridView.AutoGenerateColumns = false;
            this.Fund_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fund_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fundIDDataGridViewTextBoxColumn,
            this.fundNumDataGridViewTextBoxColumn,
            this.fundLitDataGridViewTextBoxColumn,
            this.fundNameDataGridViewTextBoxColumn,
            this.invCountDataGridViewTextBoxColumn,
            this.yearStDataGridViewTextBoxColumn,
            this.yearEndDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.Fund_dataGridView.DataSource = this.fundBindingSource;
            this.Fund_dataGridView.Location = new System.Drawing.Point(0, 52);
            this.Fund_dataGridView.Name = "Fund_dataGridView";
            this.Fund_dataGridView.Size = new System.Drawing.Size(944, 348);
            this.Fund_dataGridView.TabIndex = 19;
            this.Fund_dataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.Fund_dataGridView_UserDeletingRow);
            // 
            // fundIDDataGridViewTextBoxColumn
            // 
            this.fundIDDataGridViewTextBoxColumn.DataPropertyName = "Fund_ID";
            this.fundIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.fundIDDataGridViewTextBoxColumn.Name = "fundIDDataGridViewTextBoxColumn";
            this.fundIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fundNumDataGridViewTextBoxColumn
            // 
            this.fundNumDataGridViewTextBoxColumn.DataPropertyName = "Fund_Num";
            this.fundNumDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.fundNumDataGridViewTextBoxColumn.Name = "fundNumDataGridViewTextBoxColumn";
            // 
            // fundLitDataGridViewTextBoxColumn
            // 
            this.fundLitDataGridViewTextBoxColumn.DataPropertyName = "Fund_Lit";
            this.fundLitDataGridViewTextBoxColumn.HeaderText = "Литерал";
            this.fundLitDataGridViewTextBoxColumn.Name = "fundLitDataGridViewTextBoxColumn";
            // 
            // fundNameDataGridViewTextBoxColumn
            // 
            this.fundNameDataGridViewTextBoxColumn.DataPropertyName = "Fund_Name";
            this.fundNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.fundNameDataGridViewTextBoxColumn.Name = "fundNameDataGridViewTextBoxColumn";
            // 
            // invCountDataGridViewTextBoxColumn
            // 
            this.invCountDataGridViewTextBoxColumn.DataPropertyName = "Inv_Count";
            this.invCountDataGridViewTextBoxColumn.HeaderText = "Кол-во описей";
            this.invCountDataGridViewTextBoxColumn.Name = "invCountDataGridViewTextBoxColumn";
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
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Удалено";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            // 
            // fundBindingSource
            // 
            this.fundBindingSource.DataMember = "Fund";
            this.fundBindingSource.DataSource = this.iPSArchiveDataSet;
            // 
            // iPSArchiveDataSet
            // 
            this.iPSArchiveDataSet.DataSetName = "IPSArchiveDataSet";
            this.iPSArchiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fundTableAdapter
            // 
            this.fundTableAdapter.ClearBeforeFill = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(857, 415);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Fund_search_btn
            // 
            this.Fund_search_btn.Location = new System.Drawing.Point(12, 415);
            this.Fund_search_btn.Name = "Fund_search_btn";
            this.Fund_search_btn.Size = new System.Drawing.Size(75, 23);
            this.Fund_search_btn.TabIndex = 21;
            this.Fund_search_btn.Text = "Поиск";
            this.Fund_search_btn.UseVisualStyleBackColor = true;
            this.Fund_search_btn.Click += new System.EventHandler(this.Fund_search_btn_Click);
            // 
            // Fund_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.Fund_search_btn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.Fund_dataGridView);
            this.Controls.Add(this.panel4);
            this.Name = "Fund_table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund_table";
            this.Load += new System.EventHandler(this.Fund_table_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fund_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Registration_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView Fund_dataGridView;
        private IPSArchiveDataSet iPSArchiveDataSet;
        private System.Windows.Forms.BindingSource fundBindingSource;
        private IPSArchiveDataSetTableAdapters.FundTableAdapter fundTableAdapter;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundLitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearStDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button Fund_search_btn;
    }
}