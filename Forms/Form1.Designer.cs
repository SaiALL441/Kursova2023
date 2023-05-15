namespace WindowsFormsAppKursova
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(227)))), ((int)(((byte)(112)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkPass);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.txtlogin);
            this.panel1.Location = new System.Drawing.Point(194, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 246);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.BackgroundImage = global::WindowsFormsAppKursova.Properties.Resources.вкл;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(160, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 37);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPass.Location = new System.Drawing.Point(193, 151);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(175, 26);
            this.checkPass.TabIndex = 4;
            this.checkPass.Text = "Показати пароль";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(160, 109);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(211, 22);
            this.txtpass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(57, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 25);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Пароль:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(57, 47);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(67, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логін:";
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(160, 51);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(211, 22);
            this.txtlogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(460, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(195)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label1;
    }
}

