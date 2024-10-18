namespace Win2From
{
    partial class Calculator
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
            this.btnCler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.txbStor = new System.Windows.Forms.TextBox();
            this.btn0 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPoint = new Guna.UI2.WinForms.Guna2Button();
            this.btnEquals = new Guna.UI2.WinForms.Guna2Button();
            this.btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubtract = new Guna.UI2.WinForms.Guna2Button();
            this.btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMultiply = new Guna.UI2.WinForms.Guna2Button();
            this.btnDivision = new Guna.UI2.WinForms.Guna2Button();
            this.btnMod = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCler
            // 
            this.btnCler.BackgroundImage = global::Win2From.Properties.Resources.icons8_xbox_x_96;
            this.btnCler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCler.Font = new System.Drawing.Font("Jamstoke", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCler.Location = new System.Drawing.Point(119, 342);
            this.btnCler.Name = "btnCler";
            this.btnCler.Size = new System.Drawing.Size(101, 81);
            this.btnCler.TabIndex = 18;
            this.btnCler.UseVisualStyleBackColor = true;
            this.btnCler.Click += new System.EventHandler(this.btnCler_Click);
            this.btnCler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Win2From.Properties.Resources.Calculator_cuate__2___1_;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txbResult
            // 
            this.txbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbResult.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.ForeColor = System.Drawing.Color.Black;
            this.txbResult.Location = new System.Drawing.Point(87, 24);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(398, 96);
            this.txbResult.TabIndex = 19;
            this.txbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbStor
            // 
            this.txbStor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txbStor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbStor.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStor.ForeColor = System.Drawing.Color.Black;
            this.txbStor.Location = new System.Drawing.Point(87, 116);
            this.txbStor.Multiline = true;
            this.txbStor.Name = "txbStor";
            this.txbStor.ReadOnly = true;
            this.txbStor.Size = new System.Drawing.Size(398, 96);
            this.txbStor.TabIndex = 20;
            this.txbStor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.BorderRadius = 25;
            this.btn0.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn0.FillColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Location = new System.Drawing.Point(4, 733);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(216, 81);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click_1);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Transparent;
            this.btnPoint.BorderRadius = 25;
            this.btnPoint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPoint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPoint.FillColor = System.Drawing.Color.White;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPoint.ForeColor = System.Drawing.Color.Black;
            this.btnPoint.Location = new System.Drawing.Point(245, 733);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(101, 81);
            this.btnPoint.TabIndex = 22;
            this.btnPoint.Text = ".";
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click_1);
            this.btnPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Transparent;
            this.btnEquals.BorderRadius = 25;
            this.btnEquals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquals.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(371, 733);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(101, 81);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BorderRadius = 25;
            this.btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn1.FillColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(12, 631);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 81);
            this.btn1.TabIndex = 24;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BorderRadius = 25;
            this.btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn2.FillColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Location = new System.Drawing.Point(127, 631);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(87, 81);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click_1);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BorderRadius = 25;
            this.btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn3.FillColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Location = new System.Drawing.Point(242, 631);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(101, 81);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.BorderRadius = 25;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.Location = new System.Drawing.Point(371, 631);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(101, 81);
            this.btnPlus.TabIndex = 27;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BorderRadius = 25;
            this.btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn6.FillColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Location = new System.Drawing.Point(245, 534);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(98, 81);
            this.btn6.TabIndex = 28;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BorderRadius = 25;
            this.btn5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn5.FillColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Location = new System.Drawing.Point(127, 534);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(87, 81);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BorderRadius = 25;
            this.btn4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn4.FillColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Location = new System.Drawing.Point(12, 534);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 81);
            this.btn4.TabIndex = 30;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Transparent;
            this.btnSubtract.BorderRadius = 25;
            this.btnSubtract.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubtract.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubtract.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubtract.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubtract.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSubtract.ForeColor = System.Drawing.Color.Black;
            this.btnSubtract.Location = new System.Drawing.Point(371, 534);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(101, 81);
            this.btnSubtract.TabIndex = 31;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            this.btnSubtract.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.BorderRadius = 25;
            this.btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn9.FillColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(245, 438);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(98, 81);
            this.btn9.TabIndex = 32;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.BorderRadius = 25;
            this.btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn8.FillColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Location = new System.Drawing.Point(127, 438);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(87, 81);
            this.btn8.TabIndex = 33;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.BorderRadius = 25;
            this.btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn7.FillColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Location = new System.Drawing.Point(12, 438);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 81);
            this.btn7.TabIndex = 34;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Transparent;
            this.btnMultiply.BorderRadius = 25;
            this.btnMultiply.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultiply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultiply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultiply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(371, 438);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(101, 81);
            this.btnMultiply.TabIndex = 35;
            this.btnMultiply.Text = "x";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            this.btnMultiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Transparent;
            this.btnDivision.BorderRadius = 25;
            this.btnDivision.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDivision.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDivision.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDivision.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDivision.ForeColor = System.Drawing.Color.Black;
            this.btnDivision.Location = new System.Drawing.Point(371, 342);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(101, 81);
            this.btnDivision.TabIndex = 36;
            this.btnDivision.Text = "÷";
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            this.btnDivision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.BorderRadius = 25;
            this.btnMod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(193)))), ((int)(((byte)(243)))));
            this.btnMod.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMod.ForeColor = System.Drawing.Color.Black;
            this.btnMod.Location = new System.Drawing.Point(245, 342);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(101, 81);
            this.btnMod.TabIndex = 37;
            this.btnMod.Text = "%";
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click_1);
            this.btnMod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(497, 826);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txbStor);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnCler);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCler;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.TextBox txbStor;
        private Guna.UI2.WinForms.Guna2Button btn0;
        private Guna.UI2.WinForms.Guna2Button btnPoint;
        private Guna.UI2.WinForms.Guna2Button btnEquals;
        private Guna.UI2.WinForms.Guna2Button btn1;
        private Guna.UI2.WinForms.Guna2Button btn2;
        private Guna.UI2.WinForms.Guna2Button btn3;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btn6;
        private Guna.UI2.WinForms.Guna2Button btn5;
        private Guna.UI2.WinForms.Guna2Button btn4;
        private Guna.UI2.WinForms.Guna2Button btnSubtract;
        private Guna.UI2.WinForms.Guna2Button btn9;
        private Guna.UI2.WinForms.Guna2Button btn8;
        private Guna.UI2.WinForms.Guna2Button btn7;
        private Guna.UI2.WinForms.Guna2Button btnMultiply;
        private Guna.UI2.WinForms.Guna2Button btnDivision;
        private Guna.UI2.WinForms.Guna2Button btnMod;
    }
}