
namespace Beadando3
{
    partial class dashboard
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
            this.uC_Feladat11 = new Beadando3.UserControlls.UC_Feladat1();
            this.SuspendLayout();
            // 
            // uC_Feladat11
            // 
            this.uC_Feladat11.BackColor = System.Drawing.Color.White;
            this.uC_Feladat11.Location = new System.Drawing.Point(182, 1);
            this.uC_Feladat11.Name = "uC_Feladat11";
            this.uC_Feladat11.Size = new System.Drawing.Size(800, 800);
            this.uC_Feladat11.TabIndex = 0;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 801);
            this.Controls.Add(this.uC_Feladat11);
            this.Name = "dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlls.UC_Feladat1 uC_Feladat11;
    }
}

