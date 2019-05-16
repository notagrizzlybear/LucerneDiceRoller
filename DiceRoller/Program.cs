using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DiceRoller
{
    //rolling methods
    class DiceRoll
    {
        public Random rnd = new Random();

        public int Roll(int dicecount, int dicetype)
        {
            int result = 0;
            if (dicecount > 1 && dicetype > 1)
            {
                for (int i = 0; i < dicecount; i++)
                    result += rnd.Next(dicetype) + 1;
            }
            else if (dicecount == 0 || dicecount == 1)
                result = rnd.Next(dicetype) + 1;
            else if (dicetype == 1)
                result = dicecount;
            else
                throw new System.ArgumentException("Zły format testu");
            return result;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiceRoller());
        }
    }
}
