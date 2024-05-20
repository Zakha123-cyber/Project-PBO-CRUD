namespace _232410103061
{
    partial class WELCOMEPAGE
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
            BTNLanjut = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // BTNLanjut
            // 
            BTNLanjut.BackColor = Color.Lime;
            BTNLanjut.Location = new Point(320, 248);
            BTNLanjut.Name = "BTNLanjut";
            BTNLanjut.Size = new Size(141, 35);
            BTNLanjut.TabIndex = 2;
            BTNLanjut.Text = "Lanjut";
            BTNLanjut.UseVisualStyleBackColor = false;
            BTNLanjut.Click += BTNLanjut_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(332, 153);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "MAHASISWA";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(332, 200);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(79, 24);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "DOSEN";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 79);
            label1.Name = "label1";
            label1.Size = new Size(346, 37);
            label1.TabIndex = 5;
            label1.Text = "HALOO TEMAN TEMANN";
            // 
            // WELCOMEPAGE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(BTNLanjut);
            Name = "WELCOMEPAGE";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BTNLanjut;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
    }
}
