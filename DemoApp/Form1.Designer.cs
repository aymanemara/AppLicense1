namespace DemoApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.sebBaseString = new SerialBox.SerialBox();
            this.sebPassword = new SerialBox.SerialBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(116, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back, LapTrinhVB.NET";
            // 
            // sebBaseString
            // 
            this.sebBaseString.CaptleLettersOnly = true;
            this.sebBaseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sebBaseString.Location = new System.Drawing.Point(110, 171);
            this.sebBaseString.Margin = new System.Windows.Forms.Padding(5);
            this.sebBaseString.Name = "sebBaseString";
            this.sebBaseString.ReadOnly = true;
            this.sebBaseString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sebBaseString.Size = new System.Drawing.Size(397, 25);
            this.sebBaseString.TabIndex = 3;
            // 
            // sebPassword
            // 
            this.sebPassword.CaptleLettersOnly = true;
            this.sebPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sebPassword.Location = new System.Drawing.Point(110, 206);
            this.sebPassword.Margin = new System.Windows.Forms.Padding(5);
            this.sebPassword.Name = "sebPassword";
            this.sebPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sebPassword.Size = new System.Drawing.Size(397, 32);
            this.sebPassword.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 305);
            this.Controls.Add(this.sebPassword);
            this.Controls.Add(this.sebBaseString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo App Trial - https://laptrinhvb.net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SerialBox.SerialBox sebBaseString;
        private SerialBox.SerialBox sebPassword;
    }
}

