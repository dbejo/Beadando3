
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uC_Feladat21 = new Beadando3.UserControlls.UC_Feladat2();
            this.uC_Feladat11 = new Beadando3.UserControlls.UC_Feladat1();
            this.uC_Welcome1 = new Beadando3.UserControlls.UC_Welcome();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "1. Feladat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "2. Feladat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uC_Feladat21
            // 
            this.uC_Feladat21.BackColor = System.Drawing.Color.White;
            this.uC_Feladat21.Location = new System.Drawing.Point(182, 1);
            this.uC_Feladat21.Name = "uC_Feladat21";
            this.uC_Feladat21.Size = new System.Drawing.Size(800, 800);
            this.uC_Feladat21.TabIndex = 3;
            this.uC_Feladat21.Visible = false;
            // 
            // uC_Feladat11
            // 
            this.uC_Feladat11.BackColor = System.Drawing.Color.White;
            this.uC_Feladat11.Location = new System.Drawing.Point(182, 1);
            this.uC_Feladat11.Name = "uC_Feladat11";
            this.uC_Feladat11.Size = new System.Drawing.Size(800, 800);
            this.uC_Feladat11.TabIndex = 0;
            this.uC_Feladat11.Visible = false;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.uC_Welcome1.Location = new System.Drawing.Point(182, 1);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(800, 800);
            this.uC_Welcome1.TabIndex = 4;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 801);
            this.Controls.Add(this.uC_Welcome1);
            this.Controls.Add(this.uC_Feladat21);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_Feladat11);
            this.Name = "dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlls.UC_Feladat1 uC_Feladat11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlls.UC_Feladat2 uC_Feladat21;
        private UserControlls.UC_Welcome uC_Welcome1;
    }
}

