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
            string diceText = dicebox.Text;  // input text
            int diceCount = 0, diceType = 0;
            int i = 0, j = 0;
            int diceSignPosition = 0;

            bool inputError = false;  // used for exception handling
            warningLabel.Text = "";


            //reading roll attributes

            //reading quantity of dice
            if (char.IsDigit(diceText[0]) && diceText[0] != '0')
            {
                for (i = 0; char.IsDigit(diceText[i]); i++) { }
                diceSignPosition = i;
                Int32.TryParse(diceText.Substring(0, i), out diceCount);
            }
            // in case no number of dice is given (ex. "d100") the default quantity is 1
            else if (diceText[0] == 'd' || diceText[0] == 'k')
            {
                diceCount = 1;
                diceSignPosition = 0;
            }
            else inputError = true;
                
            //reading the type of dice (how many sides every dice should have)
            if ((diceText[diceSignPosition].Equals('d') || diceText[diceSignPosition].Equals('k')) && 
                char.IsDigit(diceText[diceSignPosition + 1]))
            {
                for (i = diceSignPosition + 1; i < diceText.Length; i++)
                {
                    if (!char.IsDigit(diceText[i]))
                    {
                        inputError = true;
                        j = 0;
                        break;
                    }
                    else j++;
                    // return diceType = 0 if any sign is not a digit!
                }
                Int32.TryParse(diceText.Substring(diceSignPosition + 1, j), out diceType);
            }

            if (diceCount != 0 && diceType != 0)
            {
                resultBox.Text = diceRoll.Roll(diceCount, diceType).ToString();
            }
            else inputError = true;

            // exception handling
            if (inputError)
            {
                warningLabel.Text = "Niewłaściwy format testu!";
                resultBox.Text = "ERR!";
            }
                
        }
    }
}
