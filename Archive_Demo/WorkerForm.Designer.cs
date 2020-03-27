namespace Archive_Demo
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FundPage = new System.Windows.Forms.TabPage();
            this.Fund_Year_End = new System.Windows.Forms.DateTimePicker();
            this.Fund_Year_St = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addFund_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Fund_Comment_btn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fund_Inv_Count_btn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fund_Name_btn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fund_Lit_btn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Fund_Num_btn = new System.Windows.Forms.TextBox();
            this.InvPage = new System.Windows.Forms.TabPage();
            this.Inv_Year_End_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Inv_Year_St_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addInv_btn = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.Inv_Comment = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Inv_Dates = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Inv_Name = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Inv_Vol = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Inv_Lit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Inv_Num = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Inv_Fund_ID_comboBox = new System.Windows.Forms.ComboBox();
            this.fundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPSArchiveDataSet = new Archive_Demo.IPSArchiveDataSet();
            this.Inv_Unit_Count = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.UnitPage = new System.Windows.Forms.TabPage();
            this.Unit_Type = new System.Windows.Forms.ComboBox();
            this.unitTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.Unit_Date_Create_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Unit_Year_End_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Unit_Year_St_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Unit_Name = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.Unit_Inv_comboBox = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label39 = new System.Windows.Forms.Label();
            this.Unit_P_Count = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Unit_Dates = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.Unit_Lit = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.Unit_Num = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.addUnit_btn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.Unit_Comment = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ReportPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.fundTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.FundTableAdapter();
            this.unitTypesTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.UnitTypesTableAdapter();
            this.inventoryTableAdapter = new Archive_Demo.IPSArchiveDataSetTableAdapters.InventoryTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.FundPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.InvPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.UnitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.ReportPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FundPage);
            this.tabControl1.Controls.Add(this.InvPage);
            this.tabControl1.Controls.Add(this.UnitPage);
            this.tabControl1.Controls.Add(this.ReportPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // FundPage
            // 
            this.FundPage.Controls.Add(this.Fund_Year_End);
            this.FundPage.Controls.Add(this.Fund_Year_St);
            this.FundPage.Controls.Add(this.label12);
            this.FundPage.Controls.Add(this.label11);
            this.FundPage.Controls.Add(this.label10);
            this.FundPage.Controls.Add(this.addFund_btn);
            this.FundPage.Controls.Add(this.label8);
            this.FundPage.Controls.Add(this.panel1);
            this.FundPage.Controls.Add(this.label7);
            this.FundPage.Controls.Add(this.Fund_Comment_btn);
            this.FundPage.Controls.Add(this.label6);
            this.FundPage.Controls.Add(this.label5);
            this.FundPage.Controls.Add(this.label4);
            this.FundPage.Controls.Add(this.Fund_Inv_Count_btn);
            this.FundPage.Controls.Add(this.label3);
            this.FundPage.Controls.Add(this.Fund_Name_btn);
            this.FundPage.Controls.Add(this.label2);
            this.FundPage.Controls.Add(this.Fund_Lit_btn);
            this.FundPage.Controls.Add(this.label1);
            this.FundPage.Controls.Add(this.Fund_Num_btn);
            this.FundPage.Location = new System.Drawing.Point(4, 22);
            this.FundPage.Name = "FundPage";
            this.FundPage.Padding = new System.Windows.Forms.Padding(3);
            this.FundPage.Size = new System.Drawing.Size(792, 424);
            this.FundPage.TabIndex = 0;
            this.FundPage.Text = "Фонды";
            this.FundPage.UseVisualStyleBackColor = true;
            // 
            // Fund_Year_End
            // 
            this.Fund_Year_End.CustomFormat = "yyyy";
            this.Fund_Year_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fund_Year_End.Location = new System.Drawing.Point(488, 194);
            this.Fund_Year_End.Name = "Fund_Year_End";
            this.Fund_Year_End.Size = new System.Drawing.Size(168, 20);
            this.Fund_Year_End.TabIndex = 69;
            // 
            // Fund_Year_St
            // 
            this.Fund_Year_St.CustomFormat = "yyyy";
            this.Fund_Year_St.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fund_Year_St.Location = new System.Drawing.Point(289, 194);
            this.Fund_Year_St.Name = "Fund_Year_St";
            this.Fund_Year_St.Size = new System.Drawing.Size(168, 20);
            this.Fund_Year_St.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(422, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(125, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(147, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // addFund_btn
            // 
            this.addFund_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.addFund_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFund_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFund_btn.Location = new System.Drawing.Point(449, 272);
            this.addFund_btn.Name = "addFund_btn";
            this.addFund_btn.Size = new System.Drawing.Size(318, 128);
            this.addFund_btn.TabIndex = 17;
            this.addFund_btn.Text = "Добавить";
            this.addFund_btn.UseVisualStyleBackColor = false;
            this.addFund_btn.Click += new System.EventHandler(this.addFund_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(463, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 58);
            this.panel1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(786, 58);
            this.label9.TabIndex = 0;
            this.label9.Text = "Добавление Фонда";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Комментарий";
            // 
            // Fund_Comment_btn
            // 
            this.Fund_Comment_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fund_Comment_btn.Location = new System.Drawing.Point(26, 272);
            this.Fund_Comment_btn.Multiline = true;
            this.Fund_Comment_btn.Name = "Fund_Comment_btn";
            this.Fund_Comment_btn.Size = new System.Drawing.Size(392, 128);
            this.Fund_Comment_btn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(483, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата закрытия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(284, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата заведения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(284, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количесвто описей";
            // 
            // Fund_Inv_Count_btn
            // 
            this.Fund_Inv_Count_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fund_Inv_Count_btn.Location = new System.Drawing.Point(289, 113);
            this.Fund_Inv_Count_btn.Name = "Fund_Inv_Count_btn";
            this.Fund_Inv_Count_btn.Size = new System.Drawing.Size(168, 32);
            this.Fund_Inv_Count_btn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя Фонда";
            // 
            // Fund_Name_btn
            // 
            this.Fund_Name_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fund_Name_btn.Location = new System.Drawing.Point(31, 188);
            this.Fund_Name_btn.Name = "Fund_Name_btn";
            this.Fund_Name_btn.Size = new System.Drawing.Size(201, 32);
            this.Fund_Name_btn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(483, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Литер Фонда";
            // 
            // Fund_Lit_btn
            // 
            this.Fund_Lit_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fund_Lit_btn.Location = new System.Drawing.Point(488, 113);
            this.Fund_Lit_btn.Name = "Fund_Lit_btn";
            this.Fund_Lit_btn.Size = new System.Drawing.Size(168, 32);
            this.Fund_Lit_btn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер Фонда";
            // 
            // Fund_Num_btn
            // 
            this.Fund_Num_btn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fund_Num_btn.Location = new System.Drawing.Point(31, 113);
            this.Fund_Num_btn.Name = "Fund_Num_btn";
            this.Fund_Num_btn.Size = new System.Drawing.Size(201, 32);
            this.Fund_Num_btn.TabIndex = 0;
            // 
            // InvPage
            // 
            this.InvPage.Controls.Add(this.Inv_Year_End_dateTimePicker);
            this.InvPage.Controls.Add(this.Inv_Year_St_dateTimePicker);
            this.InvPage.Controls.Add(this.label31);
            this.InvPage.Controls.Add(this.label30);
            this.InvPage.Controls.Add(this.label29);
            this.InvPage.Controls.Add(this.label17);
            this.InvPage.Controls.Add(this.addInv_btn);
            this.InvPage.Controls.Add(this.label28);
            this.InvPage.Controls.Add(this.Inv_Comment);
            this.InvPage.Controls.Add(this.label25);
            this.InvPage.Controls.Add(this.label26);
            this.InvPage.Controls.Add(this.label27);
            this.InvPage.Controls.Add(this.Inv_Dates);
            this.InvPage.Controls.Add(this.label23);
            this.InvPage.Controls.Add(this.Inv_Name);
            this.InvPage.Controls.Add(this.label22);
            this.InvPage.Controls.Add(this.Inv_Vol);
            this.InvPage.Controls.Add(this.label21);
            this.InvPage.Controls.Add(this.Inv_Lit);
            this.InvPage.Controls.Add(this.label20);
            this.InvPage.Controls.Add(this.Inv_Num);
            this.InvPage.Controls.Add(this.label19);
            this.InvPage.Controls.Add(this.label18);
            this.InvPage.Controls.Add(this.Inv_Fund_ID_comboBox);
            this.InvPage.Controls.Add(this.Inv_Unit_Count);
            this.InvPage.Controls.Add(this.panel2);
            this.InvPage.Location = new System.Drawing.Point(4, 22);
            this.InvPage.Name = "InvPage";
            this.InvPage.Padding = new System.Windows.Forms.Padding(3);
            this.InvPage.Size = new System.Drawing.Size(792, 424);
            this.InvPage.TabIndex = 1;
            this.InvPage.Text = "Описи";
            this.InvPage.UseVisualStyleBackColor = true;
            // 
            // Inv_Year_End_dateTimePicker
            // 
            this.Inv_Year_End_dateTimePicker.CustomFormat = "yyyy";
            this.Inv_Year_End_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Inv_Year_End_dateTimePicker.Location = new System.Drawing.Point(636, 237);
            this.Inv_Year_End_dateTimePicker.Name = "Inv_Year_End_dateTimePicker";
            this.Inv_Year_End_dateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.Inv_Year_End_dateTimePicker.TabIndex = 69;
            // 
            // Inv_Year_St_dateTimePicker
            // 
            this.Inv_Year_St_dateTimePicker.CustomFormat = "yyyy";
            this.Inv_Year_St_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Inv_Year_St_dateTimePicker.Location = new System.Drawing.Point(454, 237);
            this.Inv_Year_St_dateTimePicker.Name = "Inv_Year_St_dateTimePicker";
            this.Inv_Year_St_dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.Inv_Year_St_dateTimePicker.TabIndex = 68;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label31.ForeColor = System.Drawing.Color.Red;
            this.label31.Location = new System.Drawing.Point(286, 75);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 25);
            this.label31.TabIndex = 43;
            this.label31.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(514, 75);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 25);
            this.label30.TabIndex = 42;
            this.label30.Text = "*";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(63, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(19, 25);
            this.label29.TabIndex = 41;
            this.label29.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label17.Location = new System.Drawing.Point(599, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 50);
            this.label17.TabIndex = 17;
            this.label17.Text = "Кол-во документов, \r\nвходящих в опись";
            // 
            // addInv_btn
            // 
            this.addInv_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.addInv_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInv_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInv_btn.Location = new System.Drawing.Point(454, 280);
            this.addInv_btn.Name = "addInv_btn";
            this.addInv_btn.Size = new System.Drawing.Size(318, 128);
            this.addInv_btn.TabIndex = 39;
            this.addInv_btn.Text = "Добавить";
            this.addInv_btn.UseVisualStyleBackColor = false;
            this.addInv_btn.Click += new System.EventHandler(this.addInv_btn_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label28.Location = new System.Drawing.Point(13, 252);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(124, 25);
            this.label28.TabIndex = 38;
            this.label28.Text = "Комментарий";
            // 
            // Inv_Comment
            // 
            this.Inv_Comment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inv_Comment.Location = new System.Drawing.Point(18, 280);
            this.Inv_Comment.Multiline = true;
            this.Inv_Comment.Name = "Inv_Comment";
            this.Inv_Comment.Size = new System.Drawing.Size(405, 128);
            this.Inv_Comment.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label25.Location = new System.Drawing.Point(612, 231);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 25);
            this.label25.TabIndex = 35;
            this.label25.Text = "-";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label26.Location = new System.Drawing.Point(631, 203);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 25);
            this.label26.TabIndex = 34;
            this.label26.Text = "Дата закрытия";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label27.Location = new System.Drawing.Point(450, 203);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 25);
            this.label27.TabIndex = 32;
            this.label27.Text = "Дата заведения";
            // 
            // Inv_Dates
            // 
            this.Inv_Dates.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Dates.Location = new System.Drawing.Point(198, 242);
            this.Inv_Dates.Name = "Inv_Dates";
            this.Inv_Dates.Size = new System.Drawing.Size(225, 32);
            this.Inv_Dates.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label23.Location = new System.Drawing.Point(193, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(147, 25);
            this.label23.TabIndex = 29;
            this.label23.Text = "Период ведения";
            // 
            // Inv_Name
            // 
            this.Inv_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Name.Location = new System.Drawing.Point(198, 103);
            this.Inv_Name.Name = "Inv_Name";
            this.Inv_Name.Size = new System.Drawing.Size(175, 32);
            this.Inv_Name.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label22.Location = new System.Drawing.Point(193, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 25);
            this.label22.TabIndex = 27;
            this.label22.Text = "Имя описи";
            // 
            // Inv_Vol
            // 
            this.Inv_Vol.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Vol.Location = new System.Drawing.Point(18, 174);
            this.Inv_Vol.Name = "Inv_Vol";
            this.Inv_Vol.Size = new System.Drawing.Size(153, 32);
            this.Inv_Vol.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label21.Location = new System.Drawing.Point(13, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(98, 25);
            this.label21.TabIndex = 25;
            this.label21.Text = "Том описи";
            // 
            // Inv_Lit
            // 
            this.Inv_Lit.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Lit.Location = new System.Drawing.Point(198, 178);
            this.Inv_Lit.Name = "Inv_Lit";
            this.Inv_Lit.Size = new System.Drawing.Size(225, 32);
            this.Inv_Lit.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label20.Location = new System.Drawing.Point(193, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(182, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "Номер литера описи";
            // 
            // Inv_Num
            // 
            this.Inv_Num.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Num.Location = new System.Drawing.Point(405, 103);
            this.Inv_Num.Name = "Inv_Num";
            this.Inv_Num.Size = new System.Drawing.Size(168, 32);
            this.Inv_Num.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label19.Location = new System.Drawing.Point(400, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 25);
            this.label19.TabIndex = 21;
            this.label19.Text = "Номер описи";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label18.Location = new System.Drawing.Point(13, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 25);
            this.label18.TabIndex = 20;
            this.label18.Text = "Фонд";
            // 
            // Inv_Fund_ID_comboBox
            // 
            this.Inv_Fund_ID_comboBox.DataSource = this.fundBindingSource;
            this.Inv_Fund_ID_comboBox.DisplayMember = "Fund_Name";
            this.Inv_Fund_ID_comboBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Fund_ID_comboBox.FormattingEnabled = true;
            this.Inv_Fund_ID_comboBox.Location = new System.Drawing.Point(15, 103);
            this.Inv_Fund_ID_comboBox.Name = "Inv_Fund_ID_comboBox";
            this.Inv_Fund_ID_comboBox.Size = new System.Drawing.Size(156, 33);
            this.Inv_Fund_ID_comboBox.TabIndex = 19;
            this.Inv_Fund_ID_comboBox.ValueMember = "Fund_ID";
            this.Inv_Fund_ID_comboBox.Leave += new System.EventHandler(this.Inv_Fund_ID_comboBox_Leave);
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
            // Inv_Unit_Count
            // 
            this.Inv_Unit_Count.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Inv_Unit_Count.Location = new System.Drawing.Point(604, 141);
            this.Inv_Unit_Count.Name = "Inv_Unit_Count";
            this.Inv_Unit_Count.Size = new System.Drawing.Size(153, 32);
            this.Inv_Unit_Count.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 58);
            this.panel2.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(786, 58);
            this.label13.TabIndex = 0;
            this.label13.Text = "Добавление Описи";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnitPage
            // 
            this.UnitPage.Controls.Add(this.Unit_Type);
            this.UnitPage.Controls.Add(this.label46);
            this.UnitPage.Controls.Add(this.label45);
            this.UnitPage.Controls.Add(this.label44);
            this.UnitPage.Controls.Add(this.label43);
            this.UnitPage.Controls.Add(this.Unit_Date_Create_dateTimePicker);
            this.UnitPage.Controls.Add(this.Unit_Year_End_dateTimePicker);
            this.UnitPage.Controls.Add(this.Unit_Year_St_dateTimePicker);
            this.UnitPage.Controls.Add(this.Unit_Name);
            this.UnitPage.Controls.Add(this.label42);
            this.UnitPage.Controls.Add(this.label41);
            this.UnitPage.Controls.Add(this.label40);
            this.UnitPage.Controls.Add(this.Unit_Inv_comboBox);
            this.UnitPage.Controls.Add(this.label39);
            this.UnitPage.Controls.Add(this.Unit_P_Count);
            this.UnitPage.Controls.Add(this.label38);
            this.UnitPage.Controls.Add(this.Unit_Dates);
            this.UnitPage.Controls.Add(this.label37);
            this.UnitPage.Controls.Add(this.Unit_Lit);
            this.UnitPage.Controls.Add(this.label36);
            this.UnitPage.Controls.Add(this.Unit_Num);
            this.UnitPage.Controls.Add(this.label35);
            this.UnitPage.Controls.Add(this.label32);
            this.UnitPage.Controls.Add(this.label33);
            this.UnitPage.Controls.Add(this.label34);
            this.UnitPage.Controls.Add(this.addUnit_btn);
            this.UnitPage.Controls.Add(this.label24);
            this.UnitPage.Controls.Add(this.Unit_Comment);
            this.UnitPage.Controls.Add(this.panel3);
            this.UnitPage.Location = new System.Drawing.Point(4, 22);
            this.UnitPage.Name = "UnitPage";
            this.UnitPage.Size = new System.Drawing.Size(792, 424);
            this.UnitPage.TabIndex = 2;
            this.UnitPage.Text = "Документы";
            this.UnitPage.UseVisualStyleBackColor = true;
            // 
            // Unit_Type
            // 
            this.Unit_Type.DataSource = this.unitTypesBindingSource;
            this.Unit_Type.DisplayMember = "Name";
            this.Unit_Type.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Type.FormattingEnabled = true;
            this.Unit_Type.Location = new System.Drawing.Point(631, 94);
            this.Unit_Type.Name = "Unit_Type";
            this.Unit_Type.Size = new System.Drawing.Size(141, 33);
            this.Unit_Type.TabIndex = 74;
            this.Unit_Type.ValueMember = "ID";
            this.Unit_Type.Leave += new System.EventHandler(this.Unit_Type_Leave);
            // 
            // unitTypesBindingSource
            // 
            this.unitTypesBindingSource.DataMember = "UnitTypes";
            this.unitTypesBindingSource.DataSource = this.iPSArchiveDataSet;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label46.ForeColor = System.Drawing.Color.Red;
            this.label46.Location = new System.Drawing.Point(166, 66);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(19, 25);
            this.label46.TabIndex = 73;
            this.label46.Text = "*";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label45.ForeColor = System.Drawing.Color.Red;
            this.label45.Location = new System.Drawing.Point(662, 66);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(19, 25);
            this.label45.TabIndex = 72;
            this.label45.Text = "*";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label44.ForeColor = System.Drawing.Color.Red;
            this.label44.Location = new System.Drawing.Point(330, 66);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 25);
            this.label44.TabIndex = 71;
            this.label44.Text = "*";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label43.ForeColor = System.Drawing.Color.Red;
            this.label43.Location = new System.Drawing.Point(70, 135);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(19, 25);
            this.label43.TabIndex = 70;
            this.label43.Text = "*";
            // 
            // Unit_Date_Create_dateTimePicker
            // 
            this.Unit_Date_Create_dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Unit_Date_Create_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Unit_Date_Create_dateTimePicker.Location = new System.Drawing.Point(272, 235);
            this.Unit_Date_Create_dateTimePicker.Name = "Unit_Date_Create_dateTimePicker";
            this.Unit_Date_Create_dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.Unit_Date_Create_dateTimePicker.TabIndex = 69;
            // 
            // Unit_Year_End_dateTimePicker
            // 
            this.Unit_Year_End_dateTimePicker.CustomFormat = "yyyy";
            this.Unit_Year_End_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Unit_Year_End_dateTimePicker.Location = new System.Drawing.Point(631, 233);
            this.Unit_Year_End_dateTimePicker.Name = "Unit_Year_End_dateTimePicker";
            this.Unit_Year_End_dateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.Unit_Year_End_dateTimePicker.TabIndex = 68;
            // 
            // Unit_Year_St_dateTimePicker
            // 
            this.Unit_Year_St_dateTimePicker.CustomFormat = "yyyy";
            this.Unit_Year_St_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Unit_Year_St_dateTimePicker.Location = new System.Drawing.Point(450, 233);
            this.Unit_Year_St_dateTimePicker.Name = "Unit_Year_St_dateTimePicker";
            this.Unit_Year_St_dateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.Unit_Year_St_dateTimePicker.TabIndex = 67;
            // 
            // Unit_Name
            // 
            this.Unit_Name.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Name.Location = new System.Drawing.Point(204, 94);
            this.Unit_Name.Name = "Unit_Name";
            this.Unit_Name.Size = new System.Drawing.Size(219, 32);
            this.Unit_Name.TabIndex = 66;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label42.Location = new System.Drawing.Point(199, 66);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(137, 25);
            this.label42.TabIndex = 65;
            this.label42.Text = "Имя документа";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label41.Location = new System.Drawing.Point(267, 202);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(133, 25);
            this.label41.TabIndex = 63;
            this.label41.Text = "Дата создания";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label40.Location = new System.Drawing.Point(626, 66);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(42, 25);
            this.label40.TabIndex = 61;
            this.label40.Text = "Тип";
            // 
            // Unit_Inv_comboBox
            // 
            this.Unit_Inv_comboBox.DataSource = this.inventoryBindingSource;
            this.Unit_Inv_comboBox.DisplayMember = "Inv_Name";
            this.Unit_Inv_comboBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Inv_comboBox.FormattingEnabled = true;
            this.Unit_Inv_comboBox.Location = new System.Drawing.Point(18, 163);
            this.Unit_Inv_comboBox.Name = "Unit_Inv_comboBox";
            this.Unit_Inv_comboBox.Size = new System.Drawing.Size(168, 33);
            this.Unit_Inv_comboBox.TabIndex = 60;
            this.Unit_Inv_comboBox.ValueMember = "Inv_ID";
            this.Unit_Inv_comboBox.Leave += new System.EventHandler(this.Unit_Inv_comboBox_Leave);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.iPSArchiveDataSet;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label39.Location = new System.Drawing.Point(13, 135);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 25);
            this.label39.TabIndex = 59;
            this.label39.Text = "Опись";
            // 
            // Unit_P_Count
            // 
            this.Unit_P_Count.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_P_Count.Location = new System.Drawing.Point(450, 94);
            this.Unit_P_Count.Name = "Unit_P_Count";
            this.Unit_P_Count.Size = new System.Drawing.Size(151, 32);
            this.Unit_P_Count.TabIndex = 58;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label38.Location = new System.Drawing.Point(445, 66);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(135, 25);
            this.label38.TabIndex = 57;
            this.label38.Text = "Кол-во файлов";
            // 
            // Unit_Dates
            // 
            this.Unit_Dates.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Dates.Location = new System.Drawing.Point(450, 163);
            this.Unit_Dates.Name = "Unit_Dates";
            this.Unit_Dates.Size = new System.Drawing.Size(322, 32);
            this.Unit_Dates.TabIndex = 56;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label37.Location = new System.Drawing.Point(445, 135);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(55, 25);
            this.label37.TabIndex = 55;
            this.label37.Text = "Даты";
            // 
            // Unit_Lit
            // 
            this.Unit_Lit.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Lit.Location = new System.Drawing.Point(204, 163);
            this.Unit_Lit.Name = "Unit_Lit";
            this.Unit_Lit.Size = new System.Drawing.Size(219, 32);
            this.Unit_Lit.TabIndex = 54;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label36.Location = new System.Drawing.Point(199, 135);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(221, 25);
            this.label36.TabIndex = 53;
            this.label36.Text = "Номер литера документа";
            // 
            // Unit_Num
            // 
            this.Unit_Num.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.Unit_Num.Location = new System.Drawing.Point(18, 94);
            this.Unit_Num.Name = "Unit_Num";
            this.Unit_Num.Size = new System.Drawing.Size(168, 32);
            this.Unit_Num.TabIndex = 52;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label35.Location = new System.Drawing.Point(13, 66);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(158, 25);
            this.label35.TabIndex = 51;
            this.label35.Text = "Номер документа";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label32.Location = new System.Drawing.Point(607, 230);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 25);
            this.label32.TabIndex = 50;
            this.label32.Text = "-";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label33.Location = new System.Drawing.Point(626, 202);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 25);
            this.label33.TabIndex = 49;
            this.label33.Text = "Дата закрытия";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label34.Location = new System.Drawing.Point(445, 202);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 25);
            this.label34.TabIndex = 47;
            this.label34.Text = "Дата заведения";
            // 
            // addUnit_btn
            // 
            this.addUnit_btn.BackColor = System.Drawing.Color.LemonChiffon;
            this.addUnit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUnit_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnit_btn.Location = new System.Drawing.Point(454, 280);
            this.addUnit_btn.Name = "addUnit_btn";
            this.addUnit_btn.Size = new System.Drawing.Size(318, 128);
            this.addUnit_btn.TabIndex = 44;
            this.addUnit_btn.Text = "Добавить";
            this.addUnit_btn.UseVisualStyleBackColor = false;
            this.addUnit_btn.Click += new System.EventHandler(this.addUnit_btn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial Narrow", 15.75F);
            this.label24.Location = new System.Drawing.Point(13, 252);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 25);
            this.label24.TabIndex = 43;
            this.label24.Text = "Комментарий";
            // 
            // Unit_Comment
            // 
            this.Unit_Comment.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Unit_Comment.Location = new System.Drawing.Point(18, 280);
            this.Unit_Comment.Multiline = true;
            this.Unit_Comment.Name = "Unit_Comment";
            this.Unit_Comment.Size = new System.Drawing.Size(405, 128);
            this.Unit_Comment.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 58);
            this.panel3.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(792, 58);
            this.label14.TabIndex = 0;
            this.label14.Text = "Добавление Документа";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportPage
            // 
            this.ReportPage.Controls.Add(this.panel4);
            this.ReportPage.Location = new System.Drawing.Point(4, 22);
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Size = new System.Drawing.Size(792, 424);
            this.ReportPage.TabIndex = 4;
            this.ReportPage.Text = "Отчеты";
            this.ReportPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 58);
            this.panel4.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(792, 58);
            this.label16.TabIndex = 0;
            this.label16.Text = "Добавление Описи";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fundTableAdapter
            // 
            this.fundTableAdapter.ClearBeforeFill = true;
            // 
            // unitTypesTableAdapter
            // 
            this.unitTypesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(732, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(738, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(738, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.FundPage.ResumeLayout(false);
            this.FundPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.InvPage.ResumeLayout(false);
            this.InvPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPSArchiveDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.UnitPage.ResumeLayout(false);
            this.UnitPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ReportPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FundPage;
        private System.Windows.Forms.DateTimePicker Fund_Year_End;
        private System.Windows.Forms.DateTimePicker Fund_Year_St;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addFund_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Fund_Comment_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fund_Inv_Count_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fund_Name_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fund_Lit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fund_Num_btn;
        private System.Windows.Forms.TabPage InvPage;
        private System.Windows.Forms.DateTimePicker Inv_Year_End_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Inv_Year_St_dateTimePicker;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addInv_btn;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox Inv_Comment;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox Inv_Dates;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox Inv_Name;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Inv_Vol;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox Inv_Lit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Inv_Num;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Inv_Fund_ID_comboBox;
        private System.Windows.Forms.TextBox Inv_Unit_Count;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage UnitPage;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.DateTimePicker Unit_Date_Create_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Unit_Year_End_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Unit_Year_St_dateTimePicker;
        private System.Windows.Forms.TextBox Unit_Name;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox Unit_Inv_comboBox;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox Unit_P_Count;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox Unit_Dates;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox Unit_Lit;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox Unit_Num;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button addUnit_btn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Unit_Comment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage ReportPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Unit_Type;
        private IPSArchiveDataSet iPSArchiveDataSet;
        private System.Windows.Forms.BindingSource fundBindingSource;
        private IPSArchiveDataSetTableAdapters.FundTableAdapter fundTableAdapter;
        private System.Windows.Forms.BindingSource unitTypesBindingSource;
        private IPSArchiveDataSetTableAdapters.UnitTypesTableAdapter unitTypesTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private IPSArchiveDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}