namespace _232410103061
{
    partial class LOG_REG_MAHASISWA
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_nama = new TextBox();
            tb_nim = new TextBox();
            tb_email = new TextBox();
            tb_noHP = new TextBox();
            TB_pass = new TextBox();
            btnRegister = new Button();
            label7 = new Label();
            label8 = new Label();
            TB_nimLOG = new TextBox();
            TB_passLOG = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 25);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "MAHASISWA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 93);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "NAMA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 132);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "NIM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 166);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "EMAIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 206);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "NO.HP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 243);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "PASSWORD";
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(199, 91);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(130, 27);
            tb_nama.TabIndex = 6;
            // 
            // tb_nim
            // 
            tb_nim.Location = new Point(199, 129);
            tb_nim.Name = "tb_nim";
            tb_nim.Size = new Size(130, 27);
            tb_nim.TabIndex = 7;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(199, 166);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(130, 27);
            tb_email.TabIndex = 8;
            // 
            // tb_noHP
            // 
            tb_noHP.Location = new Point(199, 203);
            tb_noHP.Name = "tb_noHP";
            tb_noHP.Size = new Size(130, 27);
            tb_noHP.TabIndex = 9;
            // 
            // TB_pass
            // 
            TB_pass.Location = new Point(199, 240);
            TB_pass.Name = "TB_pass";
            TB_pass.Size = new Size(130, 27);
            TB_pass.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(138, 309);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 45);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += this.btnRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 94);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 12;
            label7.Text = "NIM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(468, 136);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 13;
            label8.Text = "PASSWORD";
            // 
            // TB_nimLOG
            // 
            TB_nimLOG.Location = new Point(593, 90);
            TB_nimLOG.Name = "TB_nimLOG";
            TB_nimLOG.Size = new Size(142, 27);
            TB_nimLOG.TabIndex = 14;
            // 
            // TB_passLOG
            // 
            TB_passLOG.Location = new Point(593, 132);
            TB_passLOG.Name = "TB_passLOG";
            TB_passLOG.Size = new Size(142, 27);
            TB_passLOG.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(571, 309);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 16;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            // 
            // LOG_REG_MAHASISWA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TB_passLOG);
            Controls.Add(TB_nimLOG);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegister);
            Controls.Add(TB_pass);
            Controls.Add(tb_noHP);
            Controls.Add(tb_email);
            Controls.Add(tb_nim);
            Controls.Add(tb_nama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LOG_REG_MAHASISWA";
            Text = "LOG_REG_MAHASISWA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_nama;
        private TextBox tb_nim;
        private TextBox tb_email;
        private TextBox tb_noHP;
        private TextBox TB_pass;
        private Button btnRegister;
        private Label label7;
        private Label label8;
        private TextBox TB_nimLOG;
        private TextBox TB_passLOG;
        private Button button1;
    }
}