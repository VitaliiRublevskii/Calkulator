namespace Calkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            cBtn = new Button();
            plminBtn = new Button();
            procBtn = new Button();
            delBut = new Button();
            xBtn = new Button();
            nineBtn = new Button();
            eightBtn = new Button();
            sewBtn = new Button();
            plusBtn = new Button();
            freBtn = new Button();
            twoBtn = new Button();
            oneBtn = new Button();
            minBtn = new Button();
            sixBtn = new Button();
            fiveBtn = new Button();
            forBtn = new Button();
            ravBtn = new Button();
            zptBtn = new Button();
            nullBtn = new Button();
            textLB = new Label();
            rezLB = new Label();
            histBtn = new Button();
            clearHistBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(21, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 41);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cBtn
            // 
            cBtn.BackColor = SystemColors.ControlLight;
            cBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cBtn.Location = new Point(21, 155);
            cBtn.Name = "cBtn";
            cBtn.Size = new Size(75, 50);
            cBtn.TabIndex = 1;
            cBtn.Text = "C";
            cBtn.UseVisualStyleBackColor = false;
            cBtn.Click += cBtn_Click;
            // 
            // plminBtn
            // 
            plminBtn.BackColor = SystemColors.ControlLight;
            plminBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plminBtn.Location = new Point(115, 155);
            plminBtn.Name = "plminBtn";
            plminBtn.Size = new Size(75, 50);
            plminBtn.TabIndex = 2;
            plminBtn.Text = "+/-";
            plminBtn.UseVisualStyleBackColor = false;
            plminBtn.Click += plminBtn_Click;
            // 
            // procBtn
            // 
            procBtn.BackColor = SystemColors.ControlLight;
            procBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            procBtn.Location = new Point(211, 155);
            procBtn.Name = "procBtn";
            procBtn.Size = new Size(75, 50);
            procBtn.TabIndex = 3;
            procBtn.Text = "%";
            procBtn.UseVisualStyleBackColor = false;
            procBtn.Click += procBtn_Click;
            // 
            // delBut
            // 
            delBut.BackColor = Color.Gold;
            delBut.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            delBut.Location = new Point(307, 155);
            delBut.Name = "delBut";
            delBut.Size = new Size(75, 50);
            delBut.TabIndex = 4;
            delBut.Text = "/";
            delBut.UseVisualStyleBackColor = false;
            delBut.Click += operator_Click;
            // 
            // xBtn
            // 
            xBtn.BackColor = Color.Gold;
            xBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            xBtn.Location = new Point(307, 211);
            xBtn.Name = "xBtn";
            xBtn.Size = new Size(75, 50);
            xBtn.TabIndex = 8;
            xBtn.Text = "*";
            xBtn.UseVisualStyleBackColor = false;
            xBtn.Click += operator_Click;
            // 
            // nineBtn
            // 
            nineBtn.BackColor = SystemColors.ControlDarkDark;
            nineBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nineBtn.Location = new Point(211, 211);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(75, 50);
            nineBtn.TabIndex = 7;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += button_Click;
            // 
            // eightBtn
            // 
            eightBtn.BackColor = SystemColors.ControlDarkDark;
            eightBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            eightBtn.Location = new Point(115, 211);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(75, 50);
            eightBtn.TabIndex = 6;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += button_Click;
            // 
            // sewBtn
            // 
            sewBtn.BackColor = SystemColors.ControlDarkDark;
            sewBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            sewBtn.Location = new Point(21, 211);
            sewBtn.Name = "sewBtn";
            sewBtn.Size = new Size(75, 50);
            sewBtn.TabIndex = 5;
            sewBtn.Text = "7";
            sewBtn.UseVisualStyleBackColor = false;
            sewBtn.Click += button_Click;
            // 
            // plusBtn
            // 
            plusBtn.BackColor = Color.Gold;
            plusBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            plusBtn.Location = new Point(307, 324);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(75, 50);
            plusBtn.TabIndex = 16;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.Click += operator_Click;
            // 
            // freBtn
            // 
            freBtn.BackColor = SystemColors.ControlDarkDark;
            freBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            freBtn.Location = new Point(211, 324);
            freBtn.Name = "freBtn";
            freBtn.Size = new Size(75, 50);
            freBtn.TabIndex = 15;
            freBtn.Text = "3";
            freBtn.UseVisualStyleBackColor = false;
            freBtn.Click += button_Click;
            // 
            // twoBtn
            // 
            twoBtn.BackColor = SystemColors.ControlDarkDark;
            twoBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            twoBtn.Location = new Point(115, 324);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(75, 50);
            twoBtn.TabIndex = 14;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += button_Click;
            // 
            // oneBtn
            // 
            oneBtn.BackColor = SystemColors.ControlDarkDark;
            oneBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            oneBtn.Location = new Point(21, 324);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(75, 50);
            oneBtn.TabIndex = 13;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += button_Click;
            // 
            // minBtn
            // 
            minBtn.BackColor = Color.Gold;
            minBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            minBtn.Location = new Point(307, 268);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(75, 50);
            minBtn.TabIndex = 12;
            minBtn.Text = "-";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += operator_Click;
            // 
            // sixBtn
            // 
            sixBtn.BackColor = SystemColors.ControlDarkDark;
            sixBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            sixBtn.Location = new Point(211, 268);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(75, 50);
            sixBtn.TabIndex = 11;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += button_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.BackColor = SystemColors.ControlDarkDark;
            fiveBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            fiveBtn.Location = new Point(115, 268);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(75, 50);
            fiveBtn.TabIndex = 10;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += button_Click;
            // 
            // forBtn
            // 
            forBtn.BackColor = SystemColors.ControlDarkDark;
            forBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            forBtn.Location = new Point(21, 268);
            forBtn.Name = "forBtn";
            forBtn.Size = new Size(75, 50);
            forBtn.TabIndex = 9;
            forBtn.Text = "4";
            forBtn.UseVisualStyleBackColor = false;
            forBtn.Click += button_Click;
            // 
            // ravBtn
            // 
            ravBtn.BackColor = Color.Gold;
            ravBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ravBtn.Location = new Point(307, 380);
            ravBtn.Name = "ravBtn";
            ravBtn.Size = new Size(75, 50);
            ravBtn.TabIndex = 20;
            ravBtn.Text = "=";
            ravBtn.UseVisualStyleBackColor = false;
            ravBtn.Click += ravBtn_Click;
            // 
            // zptBtn
            // 
            zptBtn.BackColor = SystemColors.ControlDarkDark;
            zptBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            zptBtn.Location = new Point(211, 380);
            zptBtn.Name = "zptBtn";
            zptBtn.Size = new Size(75, 50);
            zptBtn.TabIndex = 19;
            zptBtn.Text = ",";
            zptBtn.UseVisualStyleBackColor = false;
            zptBtn.Click += button_Click;
            // 
            // nullBtn
            // 
            nullBtn.BackColor = SystemColors.ControlDarkDark;
            nullBtn.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nullBtn.Location = new Point(21, 380);
            nullBtn.Name = "nullBtn";
            nullBtn.Size = new Size(75, 50);
            nullBtn.TabIndex = 17;
            nullBtn.Text = "0";
            nullBtn.UseVisualStyleBackColor = false;
            nullBtn.Click += button_Click;
            // 
            // textLB
            // 
            textLB.AutoSize = true;
            textLB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLB.Location = new Point(21, 24);
            textLB.Name = "textLB";
            textLB.Size = new Size(0, 21);
            textLB.TabIndex = 21;
            // 
            // rezLB
            // 
            rezLB.AutoSize = true;
            rezLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rezLB.Location = new Point(21, 24);
            rezLB.Name = "rezLB";
            rezLB.Size = new Size(0, 25);
            rezLB.TabIndex = 22;
            // 
            // histBtn
            // 
            histBtn.Location = new Point(21, 115);
            histBtn.Name = "histBtn";
            histBtn.Size = new Size(131, 23);
            histBtn.TabIndex = 23;
            histBtn.Text = "HISTORY";
            histBtn.UseVisualStyleBackColor = true;
            histBtn.Click += histBtn_Click;
            // 
            // clearHistBtn
            // 
            clearHistBtn.Location = new Point(249, 115);
            clearHistBtn.Name = "clearHistBtn";
            clearHistBtn.Size = new Size(133, 23);
            clearHistBtn.TabIndex = 24;
            clearHistBtn.Text = "CLEAR HISTORY";
            clearHistBtn.UseVisualStyleBackColor = true;
            clearHistBtn.Click += clearHistBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 466);
            Controls.Add(clearHistBtn);
            Controls.Add(histBtn);
            Controls.Add(rezLB);
            Controls.Add(textLB);
            Controls.Add(ravBtn);
            Controls.Add(zptBtn);
            Controls.Add(nullBtn);
            Controls.Add(plusBtn);
            Controls.Add(freBtn);
            Controls.Add(twoBtn);
            Controls.Add(oneBtn);
            Controls.Add(minBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(forBtn);
            Controls.Add(xBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sewBtn);
            Controls.Add(delBut);
            Controls.Add(procBtn);
            Controls.Add(plminBtn);
            Controls.Add(cBtn);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button cBtn;
        private Button plminBtn;
        private Button procBtn;
        private Button delBut;
        private Button xBtn;
        private Button nineBtn;
        private Button eightBtn;
        private Button sewBtn;
        private Button plusBtn;
        private Button freBtn;
        private Button twoBtn;
        private Button oneBtn;
        private Button minBtn;
        private Button sixBtn;
        private Button fiveBtn;
        private Button forBtn;
        private Button ravBtn;
        private Button zptBtn;
        private Button nullBtn;
        private Label textLB;
        private Label label1;
        private Label rezLB;
        private Button histBtn;
        private Button clearHistBtn;
    }
}
