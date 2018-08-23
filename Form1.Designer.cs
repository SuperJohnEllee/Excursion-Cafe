namespace Excursion
{
    partial class frmfirstpage
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
            this.btnEnterToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterToLogin
            // 
            this.btnEnterToLogin.BackgroundImage = global::Excursion.Properties.Resources.ExcursionFront;
            this.btnEnterToLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnterToLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnterToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterToLogin.Location = new System.Drawing.Point(0, 0);
            this.btnEnterToLogin.Name = "btnEnterToLogin";
            this.btnEnterToLogin.Size = new System.Drawing.Size(942, 733);
            this.btnEnterToLogin.TabIndex = 0;
            this.btnEnterToLogin.UseVisualStyleBackColor = true;
            this.btnEnterToLogin.Click += new System.EventHandler(this.btnEnterToLogin_Click);
            // 
            // frmfirstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 733);
            this.Controls.Add(this.btnEnterToLogin);
            this.Name = "frmfirstpage";
            this.Text = "EXCURSION CAFE ILOILO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterToLogin;
    }
}

