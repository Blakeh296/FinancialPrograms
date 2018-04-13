namespace FinancePrograms
{
    partial class Form1
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
            this.tbLoanAsk = new System.Windows.Forms.TextBox();
            this.tbDownPayment = new System.Windows.Forms.TextBox();
            this.tbInterest = new System.Windows.Forms.TextBox();
            this.lblLoanAsk = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblErrorHandler = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLoanAsk
            // 
            this.tbLoanAsk.Location = new System.Drawing.Point(122, 145);
            this.tbLoanAsk.Name = "tbLoanAsk";
            this.tbLoanAsk.Size = new System.Drawing.Size(100, 20);
            this.tbLoanAsk.TabIndex = 0;
            // 
            // tbDownPayment
            // 
            this.tbDownPayment.Location = new System.Drawing.Point(122, 175);
            this.tbDownPayment.Name = "tbDownPayment";
            this.tbDownPayment.Size = new System.Drawing.Size(100, 20);
            this.tbDownPayment.TabIndex = 1;
            // 
            // tbInterest
            // 
            this.tbInterest.Location = new System.Drawing.Point(122, 226);
            this.tbInterest.Name = "tbInterest";
            this.tbInterest.Size = new System.Drawing.Size(100, 20);
            this.tbInterest.TabIndex = 3;
            // 
            // lblLoanAsk
            // 
            this.lblLoanAsk.AutoSize = true;
            this.lblLoanAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanAsk.Location = new System.Drawing.Point(27, 146);
            this.lblLoanAsk.Name = "lblLoanAsk";
            this.lblLoanAsk.Size = new System.Drawing.Size(85, 16);
            this.lblLoanAsk.TabIndex = 4;
            this.lblLoanAsk.Text = "Home Price :";
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(8, 175);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(104, 16);
            this.lblDownPayment.TabIndex = 5;
            this.lblDownPayment.Text = "Down Payment :";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(23, 227);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(89, 16);
            this.lblInterest.TabIndex = 7;
            this.lblInterest.Text = "Interest Rate :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(219, 68);
            this.listBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Years",
            "Months"});
            this.comboBox1.Location = new System.Drawing.Point(11, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Years";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 36);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Morgage Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorHandler
            // 
            this.lblErrorHandler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHandler.Location = new System.Drawing.Point(0, 42);
            this.lblErrorHandler.Name = "lblErrorHandler";
            this.lblErrorHandler.Size = new System.Drawing.Size(230, 25);
            this.lblErrorHandler.TabIndex = 12;
            this.lblErrorHandler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Years",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "Months",
            "60",
            "120",
            "180",
            "240",
            "300",
            "360",
            "420"});
            this.comboBox2.Location = new System.Drawing.Point(122, 201);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 314);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblErrorHandler);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.lblLoanAsk);
            this.Controls.Add(this.tbInterest);
            this.Controls.Add(this.tbDownPayment);
            this.Controls.Add(this.tbLoanAsk);
            this.Name = "Form1";
            this.Text = "Morgage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLoanAsk;
        private System.Windows.Forms.TextBox tbDownPayment;
        private System.Windows.Forms.TextBox tbInterest;
        private System.Windows.Forms.Label lblLoanAsk;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblErrorHandler;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

