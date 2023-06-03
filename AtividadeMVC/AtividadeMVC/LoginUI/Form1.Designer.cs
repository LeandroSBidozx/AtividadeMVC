namespace AtvidadeMVC
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
            this.txtEmail = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(39, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(96, 171);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 46);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Entrar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha:";
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(96, 36);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(120, 20);
            this.tBox1.TabIndex = 3;
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(96, 72);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(120, 20);
            this.tBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtEmail);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
    }
}