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


        // iterprets input and computes the result
        // returns result of computation as an integer
        // returns -1 if something goes wrong (temporary solution!!!)
        // returns 0 if no imput is given (temporary solution!!!)
        public int ParsingInput(string input)
        {
            int number;
            int numberStart = 0, numberLength = 0;  // used in parsing
            int operand1, operand2;  // operands used during computation
            List<int> numbers = new List<int>();
            List<char> operators = new List<char>();

            char[] priority = { 'd', '^', '*', '/', '+', '-' };  // priority of operations from highest to lowest

            //bool inputException = false;

            if (input == "") return 0;  // if no input is given

            // reading input and filling both stacks
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numberStart = i;
                    numberLength = 0;
                    while (i < input.Length && char.IsDigit(input[i])) { i++; numberLength++; }  // reading the number, skipping iterations if number has more than one digit
                    Int32.TryParse(input.Substring(numberStart, numberLength), out number);
                    numbers.Add(number);
                    i--;
                }
                else if (input[i] == 'd' || input[i] == 'k')
                {
                    operators.Add('d');
                    if (operators.Count > numbers.Count)  // the case when there's no number before 'd'
                    {
                        numbers.Add(1);  // if no number before 'd' is given, the default is 1
                    }
                }
                else if (input[i] == '+')
                {
                    if (i == 0) return -1;
                    else operators.Add('+');
                }
                else if (input[i] == '-')
                {
                    if (i == 0) return -1;
                    else operators.Add('-');
                }
                else if (input[i] == '*')
                {
                    if (i == 0) return -1;
                    else operators.Add('*');
                }
                else if (input[i] == '/')
                {
                    if (i == 0) return -1;
                    else operators.Add('/');
                }
                else if (input[i] == '^')
                {
                    if (i == 0) return -1;
                    else operators.Add('^');
                }
                else if (input[i] == ' ') { }  // skip spaces
                else return -1;
            }

            if (operators.Count > numbers.Count) return -1;  // this occurs only if the input is wrong

            // computing result. Searches through the operators list and computes operations with priority from highest to lowest
            // Puts the sub-result in the place of the first operand and moves operators which are above one step down
            // Nasty nested loop, gotta think of a better solution
            while(operators[0] != '0')  // finish when there's no more operators
            {
                for(int i = 0; i < priority.Length; i++)
                {
                    for(int j = 0; j < operators.Count; j++)
                    {
                        if(operators[j] == priority[i])
                        {
                            operand1 = numbers[j];
                            operand2 = numbers[j + 1];
                            switch (operators[j])
                            {
                                case 'd':
                                    numbers[j] = Roll(operand1, operand2);
                                    break;
                                case '^':
                                    numbers[j] = (int)Math.Pow(operand1, operand2);
                                    break;
                                case '*':
                                    numbers[j] = operand1 * operand2;
                                    break;
                                case '/':
                                    numbers[j] = operand1 / operand2;
                                    break;
                                case '+':
                                    numbers[j] = operand1 + operand2;
                                    break;
                                case '-':
                                    numbers[j] = operand1 - operand2;
                                    break;
                                default:
                                    return -1; 
                            }
                            numbers[j + 1] = 0;  // this needs to be changed!!!
                            operators[j] = '0';
                            // move the operators & numbers one step down
                            for(int k = j; k < operators.Count - 1; k++)
                            {
                                operators[k] = operators[k + 1];
                                operators[k + 1] = '0';
                                numbers[k + 1] = numbers[k + 2];
                                numbers[k + 2] = 0;
                            }
                            j--; // prevents skipping of similar neighbouring operations (eg. 2+2+2)
                        }
                    }
                }
            }
            return numbers[0];  // result is the last number left in the stack (uncertain!)
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
