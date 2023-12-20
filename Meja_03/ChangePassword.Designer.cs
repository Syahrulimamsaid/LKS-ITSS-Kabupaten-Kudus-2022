namespace Meja_03
{
    partial class ChangePassword
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OLDPASS = new System.Windows.Forms.TextBox();
            this.NEWPASS = new System.Windows.Forms.TextBox();
            this.CONFIRMPASS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(249, 97);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(114, 20);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "[Employee ID]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change Password";
            // 
            // OLDPASS
            // 
            this.OLDPASS.Enabled = false;
            this.OLDPASS.Location = new System.Drawing.Point(283, 161);
            this.OLDPASS.Name = "OLDPASS";
            this.OLDPASS.Size = new System.Drawing.Size(201, 22);
            this.OLDPASS.TabIndex = 17;
            // 
            // NEWPASS
            // 
            this.NEWPASS.Location = new System.Drawing.Point(283, 216);
            this.NEWPASS.Name = "NEWPASS";
            this.NEWPASS.Size = new System.Drawing.Size(201, 22);
            this.NEWPASS.TabIndex = 18;
            // 
            // CONFIRMPASS
            // 
            this.CONFIRMPASS.Location = new System.Drawing.Point(283, 275);
            this.CONFIRMPASS.Name = "CONFIRMPASS";
            this.CONFIRMPASS.Size = new System.Drawing.Size(201, 22);
            this.CONFIRMPASS.TabIndex = 19;
            this.CONFIRMPASS.TextChanged += new System.EventHandler(this.CONFIRMPASS_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Confirm Password";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONFIRMPASS);
            this.Controls.Add(this.NEWPASS);
            this.Controls.Add(this.OLDPASS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStatus);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OLDPASS;
        private System.Windows.Forms.TextBox NEWPASS;
        private System.Windows.Forms.TextBox CONFIRMPASS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}