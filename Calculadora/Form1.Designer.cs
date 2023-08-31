namespace Calculadora
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
            btndel = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnel = new Button();
            btnmulti = new Button();
            btndiv = new Button();
            btnsum = new Button();
            btnmen = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btnig = new Button();
            btnpt = new Button();
            btn0 = new Button();
            Caja = new TextBox();
            SuspendLayout();
            // 
            // btndel
            // 
            btndel.BackColor = Color.FromArgb(224, 224, 224);
            btndel.Cursor = Cursors.Hand;
            btndel.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btndel.FlatStyle = FlatStyle.Flat;
            btndel.Location = new Point(12, 72);
            btndel.Name = "btndel";
            btndel.Size = new Size(60, 45);
            btndel.TabIndex = 0;
            btndel.Text = "CE";
            btndel.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.BorderColor = Color.White;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(12, 123);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 45);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.BorderColor = Color.White;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Location = new Point(78, 123);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 45);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonHighlight;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.BorderColor = Color.White;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(144, 123);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 45);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnel
            // 
            btnel.BackColor = Color.FromArgb(224, 224, 224);
            btnel.Cursor = Cursors.Hand;
            btnel.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnel.FlatStyle = FlatStyle.Flat;
            btnel.Location = new Point(78, 72);
            btnel.Name = "btnel";
            btnel.Size = new Size(60, 45);
            btnel.TabIndex = 4;
            btnel.Text = "←";
            btnel.UseVisualStyleBackColor = false;
            // 
            // btnmulti
            // 
            btnmulti.BackColor = Color.FromArgb(224, 224, 224);
            btnmulti.Cursor = Cursors.Hand;
            btnmulti.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnmulti.FlatStyle = FlatStyle.Flat;
            btnmulti.Location = new Point(210, 72);
            btnmulti.Name = "btnmulti";
            btnmulti.Size = new Size(60, 45);
            btnmulti.TabIndex = 7;
            btnmulti.Text = "X";
            btnmulti.UseVisualStyleBackColor = false;
            btnmulti.Click += btnmulti_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.FromArgb(224, 224, 224);
            btndiv.Cursor = Cursors.Hand;
            btndiv.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btndiv.FlatStyle = FlatStyle.Flat;
            btndiv.Location = new Point(144, 72);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(60, 45);
            btndiv.TabIndex = 6;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // btnsum
            // 
            btnsum.BackColor = Color.FromArgb(224, 224, 224);
            btnsum.Cursor = Cursors.Hand;
            btnsum.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnsum.FlatStyle = FlatStyle.Flat;
            btnsum.Location = new Point(210, 174);
            btnsum.Name = "btnsum";
            btnsum.Size = new Size(60, 45);
            btnsum.TabIndex = 15;
            btnsum.Text = "+";
            btnsum.UseVisualStyleBackColor = false;
            btnsum.Click += btnsum_Click;
            // 
            // btnmen
            // 
            btnmen.BackColor = Color.FromArgb(224, 224, 224);
            btnmen.Cursor = Cursors.Hand;
            btnmen.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnmen.FlatStyle = FlatStyle.Flat;
            btnmen.Location = new Point(210, 123);
            btnmen.Name = "btnmen";
            btnmen.Size = new Size(60, 45);
            btnmen.TabIndex = 14;
            btnmen.Text = "-";
            btnmen.UseVisualStyleBackColor = false;
            btnmen.Click += btnmen_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonHighlight;
            btn3.FlatAppearance.BorderColor = Color.White;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(144, 225);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 45);
            btn3.TabIndex = 13;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonHighlight;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.BorderColor = Color.White;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(144, 174);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 45);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.FlatAppearance.BorderColor = Color.White;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(78, 225);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 45);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderColor = Color.White;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(78, 174);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 45);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(12, 225);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 45);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderColor = Color.White;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(12, 174);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 45);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnig
            // 
            btnig.BackColor = Color.FromArgb(224, 224, 224);
            btnig.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnig.FlatStyle = FlatStyle.Flat;
            btnig.Location = new Point(210, 225);
            btnig.Name = "btnig";
            btnig.Size = new Size(60, 96);
            btnig.TabIndex = 19;
            btnig.Text = "=";
            btnig.UseVisualStyleBackColor = false;
            btnig.Click += btnig_Click;
            // 
            // btnpt
            // 
            btnpt.BackColor = Color.FromArgb(224, 224, 224);
            btnpt.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnpt.FlatStyle = FlatStyle.Flat;
            btnpt.Location = new Point(144, 276);
            btnpt.Name = "btnpt";
            btnpt.Size = new Size(60, 45);
            btnpt.TabIndex = 18;
            btnpt.Text = ".";
            btnpt.UseVisualStyleBackColor = false;
            btnpt.Click += btnpt_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonHighlight;
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.BorderColor = Color.White;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.ForeColor = SystemColors.ControlText;
            btn0.Location = new Point(12, 276);
            btn0.Name = "btn0";
            btn0.Size = new Size(126, 45);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // Caja
            // 
            Caja.BackColor = Color.Silver;
            Caja.BorderStyle = BorderStyle.None;
            Caja.Location = new Point(12, 21);
            Caja.Multiline = true;
            Caja.Name = "Caja";
            Caja.ReadOnly = true;
            Caja.Size = new Size(258, 45);
            Caja.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(285, 332);
            Controls.Add(Caja);
            Controls.Add(btnig);
            Controls.Add(btnpt);
            Controls.Add(btn0);
            Controls.Add(btnsum);
            Controls.Add(btnmen);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnmulti);
            Controls.Add(btndiv);
            Controls.Add(btn9);
            Controls.Add(btnel);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btndel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndel;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnel;
        private Button btnmulti;
        private Button btndiv;
        private Button btnsum;
        private Button btnmen;
        private Button btn3;
        private Button btn6;
        private Button btn2;
        private Button btn5;
        private Button btn1;
        private Button btn4;
        private Button btnig;
        private Button btnpt;
        private Button btn0;
        private TextBox Caja;
    }
}