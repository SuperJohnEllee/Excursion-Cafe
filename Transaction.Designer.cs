namespace Excursion
{
    partial class frmTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkCafeAuLait = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCapuchinnamon = new System.Windows.Forms.TextBox();
            this.txtCocoa = new System.Windows.Forms.TextBox();
            this.txtCafeAuLait = new System.Windows.Forms.TextBox();
            this.chkCapuchinnamon = new System.Windows.Forms.CheckBox();
            this.chkCocoa = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTunaPresto = new System.Windows.Forms.TextBox();
            this.txtCheezyCarbonara = new System.Windows.Forms.TextBox();
            this.chkTunaPresto = new System.Windows.Forms.CheckBox();
            this.chkCheezyCarbo = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPotatoMarbles = new System.Windows.Forms.TextBox();
            this.txtNachos = new System.Windows.Forms.TextBox();
            this.txtAnimalFries = new System.Windows.Forms.TextBox();
            this.chkPotatoMarbles = new System.Windows.Forms.CheckBox();
            this.chkNachos = new System.Windows.Forms.CheckBox();
            this.chkAnimalFries = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataTransaction = new System.Windows.Forms.DataGridView();
            this.TransacID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Bought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBackTransaction = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecordToRecordFrm = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblcash = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.cmbpayment = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.lblchange = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaction)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCafeAuLait
            // 
            this.chkCafeAuLait.AutoSize = true;
            this.chkCafeAuLait.BackColor = System.Drawing.Color.Transparent;
            this.chkCafeAuLait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCafeAuLait.ForeColor = System.Drawing.Color.White;
            this.chkCafeAuLait.Location = new System.Drawing.Point(19, 33);
            this.chkCafeAuLait.Name = "chkCafeAuLait";
            this.chkCafeAuLait.Size = new System.Drawing.Size(116, 24);
            this.chkCafeAuLait.TabIndex = 1;
            this.chkCafeAuLait.Text = "Cafe Au Lait";
            this.chkCafeAuLait.UseVisualStyleBackColor = false;
            this.chkCafeAuLait.CheckedChanged += new System.EventHandler(this.chkCafeAuLait_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCapuchinnamon);
            this.groupBox1.Controls.Add(this.txtCocoa);
            this.groupBox1.Controls.Add(this.txtCafeAuLait);
            this.groupBox1.Controls.Add(this.chkCapuchinnamon);
            this.groupBox1.Controls.Add(this.chkCocoa);
            this.groupBox1.Controls.Add(this.chkCafeAuLait);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffee";
            // 
            // txtCapuchinnamon
            // 
            this.txtCapuchinnamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapuchinnamon.Location = new System.Drawing.Point(179, 98);
            this.txtCapuchinnamon.Name = "txtCapuchinnamon";
            this.txtCapuchinnamon.Size = new System.Drawing.Size(60, 20);
            this.txtCapuchinnamon.TabIndex = 6;
            this.txtCapuchinnamon.Text = "0";
            this.txtCapuchinnamon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCapuchinnamon.TextChanged += new System.EventHandler(this.txtCapuchinnamon_TextChanged);
            // 
            // txtCocoa
            // 
            this.txtCocoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCocoa.Location = new System.Drawing.Point(179, 68);
            this.txtCocoa.Name = "txtCocoa";
            this.txtCocoa.Size = new System.Drawing.Size(60, 20);
            this.txtCocoa.TabIndex = 5;
            this.txtCocoa.Text = "0";
            this.txtCocoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCocoa.TextChanged += new System.EventHandler(this.txtCocoa_TextChanged);
            // 
            // txtCafeAuLait
            // 
            this.txtCafeAuLait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCafeAuLait.Location = new System.Drawing.Point(179, 36);
            this.txtCafeAuLait.Name = "txtCafeAuLait";
            this.txtCafeAuLait.Size = new System.Drawing.Size(60, 20);
            this.txtCafeAuLait.TabIndex = 4;
            this.txtCafeAuLait.Text = "0";
            this.txtCafeAuLait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCafeAuLait.TextChanged += new System.EventHandler(this.txtCafeAuLait_TextChanged);
            // 
            // chkCapuchinnamon
            // 
            this.chkCapuchinnamon.AutoSize = true;
            this.chkCapuchinnamon.BackColor = System.Drawing.Color.Transparent;
            this.chkCapuchinnamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCapuchinnamon.ForeColor = System.Drawing.Color.White;
            this.chkCapuchinnamon.Location = new System.Drawing.Point(19, 93);
            this.chkCapuchinnamon.Name = "chkCapuchinnamon";
            this.chkCapuchinnamon.Size = new System.Drawing.Size(144, 24);
            this.chkCapuchinnamon.TabIndex = 3;
            this.chkCapuchinnamon.Text = "Capuchinnamon";
            this.chkCapuchinnamon.UseVisualStyleBackColor = false;
            this.chkCapuchinnamon.CheckedChanged += new System.EventHandler(this.chkCapuchino_CheckedChanged);
            // 
            // chkCocoa
            // 
            this.chkCocoa.AutoSize = true;
            this.chkCocoa.BackColor = System.Drawing.Color.Transparent;
            this.chkCocoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCocoa.ForeColor = System.Drawing.Color.White;
            this.chkCocoa.Location = new System.Drawing.Point(19, 63);
            this.chkCocoa.Name = "chkCocoa";
            this.chkCocoa.Size = new System.Drawing.Size(74, 24);
            this.chkCocoa.TabIndex = 2;
            this.chkCocoa.Text = "Cocoa";
            this.chkCocoa.UseVisualStyleBackColor = false;
            this.chkCocoa.CheckedChanged += new System.EventHandler(this.chkCocoa_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtTunaPresto);
            this.groupBox2.Controls.Add(this.txtCheezyCarbonara);
            this.groupBox2.Controls.Add(this.chkTunaPresto);
            this.groupBox2.Controls.Add(this.chkCheezyCarbo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 98);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pasta";
            // 
            // txtTunaPresto
            // 
            this.txtTunaPresto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTunaPresto.Location = new System.Drawing.Point(179, 68);
            this.txtTunaPresto.Name = "txtTunaPresto";
            this.txtTunaPresto.Size = new System.Drawing.Size(60, 20);
            this.txtTunaPresto.TabIndex = 5;
            this.txtTunaPresto.Text = "0";
            this.txtTunaPresto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTunaPresto.TextChanged += new System.EventHandler(this.txtTunaPresto_TextChanged);
            // 
            // txtCheezyCarbonara
            // 
            this.txtCheezyCarbonara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheezyCarbonara.Location = new System.Drawing.Point(179, 36);
            this.txtCheezyCarbonara.Name = "txtCheezyCarbonara";
            this.txtCheezyCarbonara.Size = new System.Drawing.Size(60, 20);
            this.txtCheezyCarbonara.TabIndex = 4;
            this.txtCheezyCarbonara.Text = "0";
            this.txtCheezyCarbonara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheezyCarbonara.TextChanged += new System.EventHandler(this.txtCheezyCarbonara_TextChanged);
            // 
            // chkTunaPresto
            // 
            this.chkTunaPresto.AutoSize = true;
            this.chkTunaPresto.BackColor = System.Drawing.Color.Transparent;
            this.chkTunaPresto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTunaPresto.ForeColor = System.Drawing.Color.White;
            this.chkTunaPresto.Location = new System.Drawing.Point(19, 63);
            this.chkTunaPresto.Name = "chkTunaPresto";
            this.chkTunaPresto.Size = new System.Drawing.Size(114, 24);
            this.chkTunaPresto.TabIndex = 2;
            this.chkTunaPresto.Text = "Tuna Presto";
            this.chkTunaPresto.UseVisualStyleBackColor = false;
            this.chkTunaPresto.CheckedChanged += new System.EventHandler(this.chkTunaPresto_CheckedChanged);
            // 
            // chkCheezyCarbo
            // 
            this.chkCheezyCarbo.AutoSize = true;
            this.chkCheezyCarbo.BackColor = System.Drawing.Color.Transparent;
            this.chkCheezyCarbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheezyCarbo.ForeColor = System.Drawing.Color.White;
            this.chkCheezyCarbo.Location = new System.Drawing.Point(19, 33);
            this.chkCheezyCarbo.Name = "chkCheezyCarbo";
            this.chkCheezyCarbo.Size = new System.Drawing.Size(160, 24);
            this.chkCheezyCarbo.TabIndex = 1;
            this.chkCheezyCarbo.Text = "Cheezy Carbonara";
            this.chkCheezyCarbo.UseVisualStyleBackColor = false;
            this.chkCheezyCarbo.CheckedChanged += new System.EventHandler(this.chkCheezyCarbo_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtPotatoMarbles);
            this.groupBox3.Controls.Add(this.txtNachos);
            this.groupBox3.Controls.Add(this.txtAnimalFries);
            this.groupBox3.Controls.Add(this.chkPotatoMarbles);
            this.groupBox3.Controls.Add(this.chkNachos);
            this.groupBox3.Controls.Add(this.chkAnimalFries);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 129);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pica Pica";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtPotatoMarbles
            // 
            this.txtPotatoMarbles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPotatoMarbles.Location = new System.Drawing.Point(179, 96);
            this.txtPotatoMarbles.Name = "txtPotatoMarbles";
            this.txtPotatoMarbles.Size = new System.Drawing.Size(60, 20);
            this.txtPotatoMarbles.TabIndex = 6;
            this.txtPotatoMarbles.Text = "0";
            this.txtPotatoMarbles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPotatoMarbles.TextChanged += new System.EventHandler(this.txtPotatoMarbles_TextChanged);
            // 
            // txtNachos
            // 
            this.txtNachos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNachos.Location = new System.Drawing.Point(179, 66);
            this.txtNachos.Name = "txtNachos";
            this.txtNachos.Size = new System.Drawing.Size(60, 20);
            this.txtNachos.TabIndex = 5;
            this.txtNachos.Text = "0";
            this.txtNachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNachos.TextChanged += new System.EventHandler(this.txtNachos_TextChanged);
            // 
            // txtAnimalFries
            // 
            this.txtAnimalFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalFries.Location = new System.Drawing.Point(179, 34);
            this.txtAnimalFries.Name = "txtAnimalFries";
            this.txtAnimalFries.Size = new System.Drawing.Size(60, 20);
            this.txtAnimalFries.TabIndex = 4;
            this.txtAnimalFries.Text = "0";
            this.txtAnimalFries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnimalFries.TextChanged += new System.EventHandler(this.txtAnimalFries_TextChanged);
            // 
            // chkPotatoMarbles
            // 
            this.chkPotatoMarbles.AutoSize = true;
            this.chkPotatoMarbles.BackColor = System.Drawing.Color.Transparent;
            this.chkPotatoMarbles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPotatoMarbles.ForeColor = System.Drawing.Color.White;
            this.chkPotatoMarbles.Location = new System.Drawing.Point(19, 93);
            this.chkPotatoMarbles.Name = "chkPotatoMarbles";
            this.chkPotatoMarbles.Size = new System.Drawing.Size(135, 24);
            this.chkPotatoMarbles.TabIndex = 3;
            this.chkPotatoMarbles.Text = "Potato Marbles";
            this.chkPotatoMarbles.UseVisualStyleBackColor = false;
            this.chkPotatoMarbles.CheckedChanged += new System.EventHandler(this.chkPotatoMarbles_CheckedChanged);
            // 
            // chkNachos
            // 
            this.chkNachos.AutoSize = true;
            this.chkNachos.BackColor = System.Drawing.Color.Transparent;
            this.chkNachos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNachos.ForeColor = System.Drawing.Color.White;
            this.chkNachos.Location = new System.Drawing.Point(19, 63);
            this.chkNachos.Name = "chkNachos";
            this.chkNachos.Size = new System.Drawing.Size(82, 24);
            this.chkNachos.TabIndex = 2;
            this.chkNachos.Text = "Nachos";
            this.chkNachos.UseVisualStyleBackColor = false;
            this.chkNachos.CheckedChanged += new System.EventHandler(this.chkNachos_CheckedChanged);
            // 
            // chkAnimalFries
            // 
            this.chkAnimalFries.AutoSize = true;
            this.chkAnimalFries.BackColor = System.Drawing.Color.Transparent;
            this.chkAnimalFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnimalFries.ForeColor = System.Drawing.Color.White;
            this.chkAnimalFries.Location = new System.Drawing.Point(19, 33);
            this.chkAnimalFries.Name = "chkAnimalFries";
            this.chkAnimalFries.Size = new System.Drawing.Size(115, 24);
            this.chkAnimalFries.TabIndex = 1;
            this.chkAnimalFries.Text = "Animal Fries";
            this.chkAnimalFries.UseVisualStyleBackColor = false;
            this.chkAnimalFries.CheckedChanged += new System.EventHandler(this.chkAnimalFries_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Excursion Cafe";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataTransaction);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(322, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(881, 368);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // dataTransaction
            // 
            this.dataTransaction.AllowUserToAddRows = false;
            this.dataTransaction.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTransaction.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransacID,
            this.Quantity,
            this.ProductName,
            this.Price,
            this.Date_Bought});
            this.dataTransaction.GridColor = System.Drawing.Color.White;
            this.dataTransaction.Location = new System.Drawing.Point(6, 20);
            this.dataTransaction.Name = "dataTransaction";
            this.dataTransaction.ReadOnly = true;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataTransaction.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTransaction.Size = new System.Drawing.Size(870, 342);
            this.dataTransaction.TabIndex = 1;
            // 
            // TransacID
            // 
            this.TransacID.HeaderText = "ID";
            this.TransacID.Name = "TransacID";
            this.TransacID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Pcs";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 76;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Item";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 250;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Date_Bought
            // 
            this.Date_Bought.HeaderText = "Date";
            this.Date_Bought.Name = "Date_Bought";
            this.Date_Bought.ReadOnly = true;
            this.Date_Bought.Width = 350;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(272, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = ">>";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBackTransaction
            // 
            this.btnBackTransaction.BackColor = System.Drawing.Color.White;
            this.btnBackTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackTransaction.Location = new System.Drawing.Point(12, 9);
            this.btnBackTransaction.Name = "btnBackTransaction";
            this.btnBackTransaction.Size = new System.Drawing.Size(75, 34);
            this.btnBackTransaction.TabIndex = 9;
            this.btnBackTransaction.Tag = "";
            this.btnBackTransaction.Text = "Back";
            this.btnBackTransaction.UseVisualStyleBackColor = false;
            this.btnBackTransaction.Click += new System.EventHandler(this.btnBackTransaction_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDelete.Location = new System.Drawing.Point(328, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 37);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecordToRecordFrm
            // 
            this.btnRecordToRecordFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordToRecordFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordToRecordFrm.Location = new System.Drawing.Point(166, 104);
            this.btnRecordToRecordFrm.Name = "btnRecordToRecordFrm";
            this.btnRecordToRecordFrm.Size = new System.Drawing.Size(125, 40);
            this.btnRecordToRecordFrm.TabIndex = 11;
            this.btnRecordToRecordFrm.Text = "Record";
            this.btnRecordToRecordFrm.UseVisualStyleBackColor = true;
            this.btnRecordToRecordFrm.Click += new System.EventHandler(this.btnRecordToRecordFrm_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnTotal);
            this.groupBox5.Controls.Add(this.lbltotal);
            this.groupBox5.Controls.Add(this.btnRecordToRecordFrm);
            this.groupBox5.Controls.Add(this.lblcash);
            this.groupBox5.Controls.Add(this.txtchange);
            this.groupBox5.Controls.Add(this.cmbpayment);
            this.groupBox5.Controls.Add(this.txttotal);
            this.groupBox5.Controls.Add(this.txtcash);
            this.groupBox5.Controls.Add(this.lblchange);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(12, 493);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 162);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // btnTotal
            // 
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(19, 104);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(125, 40);
            this.btnTotal.TabIndex = 31;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(164, 26);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(64, 20);
            this.lbltotal.TabIndex = 27;
            this.lbltotal.Text = "TOTAL";
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcash.Location = new System.Drawing.Point(43, 16);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(58, 20);
            this.lblcash.TabIndex = 24;
            this.lblcash.Text = "CASH";
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(254, 57);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(96, 20);
            this.txtchange.TabIndex = 30;
            // 
            // cmbpayment
            // 
            this.cmbpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpayment.FormattingEnabled = true;
            this.cmbpayment.Location = new System.Drawing.Point(21, 39);
            this.cmbpayment.Name = "cmbpayment";
            this.cmbpayment.Size = new System.Drawing.Size(103, 24);
            this.cmbpayment.TabIndex = 25;
            this.cmbpayment.SelectedIndexChanged += new System.EventHandler(this.cmbpayment_SelectedIndexChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(254, 26);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(96, 20);
            this.txttotal.TabIndex = 29;
            // 
            // txtcash
            // 
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(35, 69);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(75, 20);
            this.txtcash.TabIndex = 26;
            this.txtcash.Text = "0";
            this.txtcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchange.Location = new System.Drawing.Point(164, 57);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(84, 20);
            this.lblchange.TabIndex = 28;
            this.lblchange.Text = "CHANGE";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Excursion.Properties.Resources.transactionBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 733);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBackTransaction);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmTransaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTransaction)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCafeAuLait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCapuchinnamon;
        private System.Windows.Forms.TextBox txtCocoa;
        private System.Windows.Forms.TextBox txtCafeAuLait;
        private System.Windows.Forms.CheckBox chkCapuchinnamon;
        private System.Windows.Forms.CheckBox chkCocoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTunaPresto;
        private System.Windows.Forms.TextBox txtCheezyCarbonara;
        private System.Windows.Forms.CheckBox chkTunaPresto;
        private System.Windows.Forms.CheckBox chkCheezyCarbo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPotatoMarbles;
        private System.Windows.Forms.TextBox txtNachos;
        private System.Windows.Forms.TextBox txtAnimalFries;
        private System.Windows.Forms.CheckBox chkPotatoMarbles;
        private System.Windows.Forms.CheckBox chkNachos;
        private System.Windows.Forms.CheckBox chkAnimalFries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBackTransaction;
        private System.Windows.Forms.DataGridView dataTransaction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecordToRecordFrm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransacID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Bought;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblcash;
        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.ComboBox cmbpayment;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Button btnTotal;
    }
}