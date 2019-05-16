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

        public string ParsingInput(string input)
        {
            int number;
            int numberStart = 0, numberLength = 0;  // used in parsing
            int operand1, operand2;  // operands used during computation
            Stack<int> numbers = new Stack<int>();
            Stack<char> operators = new Stack<char>();

            //bool inputException = false;

            if (input == "") return "no input";  // if no input is given

            // reading input and filling both stacks
            for(int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numberStart = i;
                    numberLength = 0;
                    while(i < input.Length && char.IsDigit(input[i])){ i++; numberLength++; }  // reading the number, skipping iterations if number has more than one digit
                    Int32.TryParse(input.Substring(numberStart, numberLength), out number);
                    numbers.Push(number);
                    i--;
                }
                else if (input[i] == 'd' || input[i] == 'k')
                {
                    operators.Push('d');
                    if (operators.Count > numbers.Count)  // the case when there's no number before 'd'
                    {
                        numbers.Push(1);  // if no number before 'd' is given, the default is 1
                    }
                }
                else if (input[i] == '+')
                {
                    if (i == 0) return null;
                    else operators.Push('+');
                }
                else if (input[i] == '-')
                {
                    if (i == 0) return null;
                    else operators.Push('-');
                }
                else if (input[i] == '*')
                {
                    if (i == 0) return null;
                    else operators.Push('*');
                }
                else if (input[i] == '/')
                {
                    if (i == 0) return null;
                    else operators.Push('/');
                }
                else if (input[i] == '^')
                {
                    if (i == 0) return null;
                    else operators.Push('^');
                }
                else return null;
            }

            if (operators.Count > numbers.Count) return null;  // it occurs only if the input is wrong

            // computing result
            while(operators.Count > 0 && numbers.Count > 1)
            {
                operand2 = numbers.Pop();
                operand1 = numbers.Pop();
                switch (operators.Pop())
                {
                    case 'd':
                        numbers.Push(Roll(operand1, operand2));
                        break;
                    case '+':
                        numbers.Push(operand1 + operand2);
                        break;
                    case '-':
                        numbers.Push(operand1 - operand2);
                        break;
                    case '*':
                        numbers.Push(operand1 * operand2);
                        break;
                    case '/':
                        numbers.Push(operand1 / operand2);
                        break;
                    case '^':
                        numbers.Push(operand1 ^ operand2);
                        break;
                    default:
                        return null;
                }
            }
            return numbers.Pop().ToString();  // result is the last number left in the stack (uncertain!)
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
