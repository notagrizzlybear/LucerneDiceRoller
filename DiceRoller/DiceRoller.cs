using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class DiceRoller : Form
    {
        DiceRoll diceRoll = new DiceRoll(); // initialized here to use only one instance of Random
                                            // the seed is reset every initialization

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        public DiceRoller()
        {
            InitializeComponent();
            this.ActiveControl = diceBox;
            diceBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void diceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int result;
            if (String.IsNullOrWhiteSpace(diceBox.Text)) resultBox.Text = "";
            else
            {
                result = diceRoll.ParsingInput(diceBox.Text);
                if (result == -1) resultBox.Text = "ERROR!";
                else resultBox.Text = result.ToString();
            }
        }

        private void diceBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int result;
                if (String.IsNullOrWhiteSpace(diceBox.Text)) resultBox.Text = "";
                else
                {
                    result = diceRoll.ParsingInput(diceBox.Text);
                    if (result == -1) resultBox.Text = "ERROR!";
                    else resultBox.Text = result.ToString();
                }
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.Show();
        }
    }
}
