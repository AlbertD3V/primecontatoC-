namespace PrimeiroProgeto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SOMAR = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13F);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(145, 27);
            label1.Name = "label1";
            label1.Size = new Size(471, 28);
            label1.TabIndex = 0;
            label1.Text = "informe numeros inteiros a ser somado";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13F);
            label2.ForeColor = SystemColors.InactiveBorder;
            label2.Location = new Point(99, 106);
            label2.Name = "label2";
            label2.Size = new Size(215, 28);
            label2.TabIndex = 1;
            label2.Text = "Primeiro numero";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 13F);
            label3.ForeColor = SystemColors.InactiveBorder;
            label3.Location = new Point(102, 178);
            label3.Name = "label3";
            label3.Size = new Size(206, 28);
            label3.TabIndex = 2;
            label3.Text = "Segundo numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 13F);
            label4.ForeColor = SystemColors.InactiveBorder;
            label4.Location = new Point(315, 226);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 3;
            label4.Click += label4_Click;
            // 
            // SOMAR
            // 
            SOMAR.Location = new Point(315, 294);
            SOMAR.Name = "SOMAR";
            SOMAR.Size = new Size(167, 66);
            SOMAR.TabIndex = 6;
            SOMAR.Text = "SOMAR";
            SOMAR.UseVisualStyleBackColor = true;
            SOMAR.Click += SOMAR_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(315, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 13F);
            label5.ForeColor = SystemColors.InactiveBorder;
            label5.Location = new Point(385, 147);
            label5.Name = "label5";
            label5.Size = new Size(24, 28);
            label5.TabIndex = 9;
            label5.Text = "+";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SOMAR);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SOMAR;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
    }
}
