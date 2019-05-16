namespace DiceRoller
{
    partial class DiceRoller
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
            this.dicebox = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.dicelbl = new System.Windows.Forms.Label();
            this.rollbttn = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dicebox
            // 
            this.dicebox.Location = new System.Drawing.Point(41, 52);
            this.dicebox.Name = "dicebox";
            this.dicebox.Size = new System.Drawing.Size(100, 20);
            this.dicebox.TabIndex = 0;
            this.dicebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(177, 52);
            this.resultbox.Name = "resultbox";
            this.resultbox.ReadOnly = true;
            this.resultbox.Size = new System.Drawing.Size(100, 20);
            this.resultbox.TabIndex = 1;
            this.resultbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dicelbl
            // 
            this.dicelbl.AutoSize = true;
            this.dicelbl.Font = new System.Drawing.Font("Garamond", 12F);
            this.dicelbl.Location = new System.Drawing.Point(37, 27);
            this.dicelbl.Name = "dicelbl";
            this.dicelbl.Size = new System.Drawing.Size(45, 18);
            this.dicelbl.TabIndex = 2;
            this.dicelbl.Text = "Kości";
            this.dicelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // rollbttn
            // 
            this.rollbttn.Location = new System.Drawing.Point(41, 78);
            this.rollbttn.Name = "rollbttn";
            this.rollbttn.Size = new System.Drawing.Size(75, 23);
            this.rollbttn.TabIndex = 4;
            this.rollbttn.Text = "Rzuć";
            this.rollbttn.UseVisualStyleBackColor = true;
            this.rollbttn.Click += new System.EventHandler(this.rollbttn_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultlbl.Location = new System.Drawing.Point(173, 27);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(49, 18);
            this.resultlbl.TabIndex = 5;
            this.resultlbl.Text = "Wynik";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Garamond", 12F);
            this.warningLabel.Location = new System.Drawing.Point(76, 114);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 18);
            this.warningLabel.TabIndex = 6;
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(328, 152);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.rollbttn);
            this.Controls.Add(this.dicelbl);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.dicebox);
            this.Name = "DiceRoller";
            this.Text = "DiceRoller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dicebox;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Label dicelbl;
        private System.Windows.Forms.Button rollbttn;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label warningLabel;
    }
}

