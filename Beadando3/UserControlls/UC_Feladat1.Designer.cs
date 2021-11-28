
namespace Beadando3.UserControlls
{
    partial class UC_Feladat1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblCharCounterSpaces = new System.Windows.Forms.Label();
            this.lblWordCounter = new System.Windows.Forms.Label();
            this.lblCharCounter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(794, 613);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(603, 763);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(706, 763);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblCharCounterSpaces
            // 
            this.lblCharCounterSpaces.AutoSize = true;
            this.lblCharCounterSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharCounterSpaces.Location = new System.Drawing.Point(19, 628);
            this.lblCharCounterSpaces.Name = "lblCharCounterSpaces";
            this.lblCharCounterSpaces.Size = new System.Drawing.Size(177, 18);
            this.lblCharCounterSpaces.TabIndex = 3;
            this.lblCharCounterSpaces.Text = "Characters (with spaces):";
            // 
            // lblWordCounter
            // 
            this.lblWordCounter.AutoSize = true;
            this.lblWordCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWordCounter.Location = new System.Drawing.Point(19, 690);
            this.lblWordCounter.Name = "lblWordCounter";
            this.lblWordCounter.Size = new System.Drawing.Size(57, 18);
            this.lblWordCounter.TabIndex = 4;
            this.lblWordCounter.Text = "Words:";
            // 
            // lblCharCounter
            // 
            this.lblCharCounter.AutoSize = true;
            this.lblCharCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharCounter.Location = new System.Drawing.Point(19, 659);
            this.lblCharCounter.Name = "lblCharCounter";
            this.lblCharCounter.Size = new System.Drawing.Size(198, 18);
            this.lblCharCounter.TabIndex = 5;
            this.lblCharCounter.Text = "Characters (without spaces):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 627);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(706, 626);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 7;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCounter.Location = new System.Drawing.Point(19, 721);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(276, 18);
            this.lblCounter.TabIndex = 8;
            this.lblCounter.Text = "Number of times when # appears in text: ";
            // 
            // UC_Feladat1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCharCounter);
            this.Controls.Add(this.lblWordCounter);
            this.Controls.Add(this.lblCharCounterSpaces);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBox1);
            this.Name = "UC_Feladat1";
            this.Size = new System.Drawing.Size(800, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblCharCounterSpaces;
        private System.Windows.Forms.Label lblWordCounter;
        private System.Windows.Forms.Label lblCharCounter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCounter;
    }
}
