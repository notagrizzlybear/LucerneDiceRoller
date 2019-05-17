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
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollbttn_Click(object sender, EventArgs e)
        {
            int result = diceRoll.ParsingInput(diceBox.Text);
            if (result == -1) resultBox.Text = "ERR!";
            else if (result == 0) resultBox.Text = "";
            else resultBox.Text = result.ToString();
        }
    }
}
