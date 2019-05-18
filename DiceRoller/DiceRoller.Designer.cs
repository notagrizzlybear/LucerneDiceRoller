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
            this.diceBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.diceLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.instructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diceBox
            // 
            this.diceBox.Location = new System.Drawing.Point(41, 52);
            this.diceBox.Name = "diceBox";
            this.diceBox.Size = new System.Drawing.Size(100, 20);
            this.diceBox.TabIndex = 0;
            this.diceBox.TextChanged += new System.EventHandler(this.diceBox_TextChanged);
            this.diceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diceBox_KeyDown);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(177, 52);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 1;
            this.resultBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // diceLabel
            // 
            this.diceLabel.AutoSize = true;
            this.diceLabel.Font = new System.Drawing.Font("Garamond", 12F);
            this.diceLabel.Location = new System.Drawing.Point(37, 27);
            this.diceLabel.Name = "diceLabel";
            this.diceLabel.Size = new System.Drawing.Size(45, 18);
            this.diceLabel.TabIndex = 2;
            this.diceLabel.Text = "Kości";
            this.diceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(41, 78);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Rzuć";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(173, 27);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(49, 18);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Wynik";
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
            // instructionButton
            // 
            this.instructionButton.Location = new System.Drawing.Point(241, 117);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(75, 23);
            this.instructionButton.TabIndex = 7;
            this.instructionButton.Text = "Instrukcja";
            this.instructionButton.UseVisualStyleBackColor = true;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(328, 152);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.diceLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.diceBox);
            this.Name = "DiceRoller";
            this.Text = "Lucerne DiceRoller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diceBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label diceLabel;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button instructionButton;
    }
}

