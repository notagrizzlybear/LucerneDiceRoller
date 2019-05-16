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
            string dicesText = dicebox.Text;
            string diceTypeText;
            int diceCount = 0, diceType = 0;
            DiceRoll diceRoll = new DiceRoll();
            int i = 0, j = 0;
            int diceSignPosition = 0;
            //reading roll attributes
            //reading quantity of dice
            if (char.IsDigit(dicesText[0]))
            {
                warningLabel.Text = "";
                for (i = 0; char.IsDigit(dicesText[i]); i++) { }
                diceSignPosition = i;
                Int32.TryParse(dicesText.Substring(0, i), out diceCount);
            }
            //reading type of dice (if quantity of dice is given)
            if ((dicesText[diceSignPosition].Equals('d') || dicesText[diceSignPosition].Equals('k')) && 
                char.IsDigit(dicesText[diceSignPosition + 1]))
            {
                for (i = diceSignPosition + 1; i < dicesText.Length; i++)
                {
                    if (!char.IsDigit(dicesText[i]))
                    {
                        warningLabel.Text = "Niewłaściwy format testu!";
                        break;
                    }
                    else j++;
                    // return diceType = 0 if any sign is not a digit!
                }

                //resultbox.Text = dicesText.Substring(diceSignPosition + 1, i);
                diceTypeText = dicesText.Substring(diceSignPosition + 1, j);
                Int32.TryParse(dicesText.Substring(diceSignPosition + 1, j), out diceType);
            }

            if (diceCount != 0 && diceType != 0)
            {
                resultbox.Text = diceRoll.Roll(diceCount, diceType).ToString();
            }
            else warningLabel.Text = "Niewłaściwy format testu!";
        }
    }
}
