
namespace PasswordHasher
{
    partial class Hasher
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
            this.hash = new System.Windows.Forms.Button();
            this.originalPassword = new System.Windows.Forms.TextBox();
            this.hashedPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyPassword = new System.Windows.Forms.Button();
            this.copyStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(463, 246);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(192, 65);
            this.hash.TabIndex = 0;
            this.hash.Text = "Hash";
            this.hash.UseVisualStyleBackColor = true;
            this.hash.Click += new System.EventHandler(this.hash_Click);
            // 
            // originalPassword
            // 
            this.originalPassword.Location = new System.Drawing.Point(13, 68);
            this.originalPassword.Name = "originalPassword";
            this.originalPassword.Size = new System.Drawing.Size(642, 32);
            this.originalPassword.TabIndex = 1;
            // 
            // hashedPassword
            // 
            this.hashedPassword.Location = new System.Drawing.Point(13, 168);
            this.hashedPassword.Name = "hashedPassword";
            this.hashedPassword.Size = new System.Drawing.Size(553, 32);
            this.hashedPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hashed password:";
            // 
            // copyPassword
            // 
            this.copyPassword.Enabled = false;
            this.copyPassword.Location = new System.Drawing.Point(572, 168);
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.Size = new System.Drawing.Size(83, 32);
            this.copyPassword.TabIndex = 0;
            this.copyPassword.Text = "Copy";
            this.copyPassword.UseVisualStyleBackColor = true;
            this.copyPassword.Click += new System.EventHandler(this.copyPassword_Click);
            // 
            // copyStatus
            // 
            this.copyStatus.AutoSize = true;
            this.copyStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyStatus.ForeColor = System.Drawing.Color.OliveDrab;
            this.copyStatus.Location = new System.Drawing.Point(13, 203);
            this.copyStatus.Name = "copyStatus";
            this.copyStatus.Size = new System.Drawing.Size(14, 20);
            this.copyStatus.TabIndex = 4;
            this.copyStatus.Text = "-";
            // 
            // Hasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 348);
            this.Controls.Add(this.copyStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashedPassword);
            this.Controls.Add(this.originalPassword);
            this.Controls.Add(this.copyPassword);
            this.Controls.Add(this.hash);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Hasher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Hasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hash;
        private System.Windows.Forms.TextBox originalPassword;
        private System.Windows.Forms.TextBox hashedPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyPassword;
        private System.Windows.Forms.Label copyStatus;
    }
}

