using System;
using System.Collections.Generic;

namespace Calculate
{
    public static class PolishCalculate
    {
        /// <summary>
        /// The Calculate method takes an expression as a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns>returns the result</returns>
        public static double Calaculate(string input)
        {
            string output = GetExpression(input);
            double result = Counting(output);
            return result;
        }
        /// <summary>
        /// Method that converts an input string with an expression to postfix notation
        /// </summary>
        /// <param name="input"></param>
        /// <returns>returns the result</returns>
        private static string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operatorStore = new Stack<char>();

            for(int i = 0; i < input.Length; i++)
            {
                if (IsSeparator(input[i]))
                    continue;

                if(Char.IsDigit(input[i]))
                {
                    while(!IsSeparator(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " ";
                    i--;
                }

                if(IsOperator(input[i]))
                {
                    if (input[i] == '(')
                        operatorStore.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        char c = operatorStore.Pop();

                        while (c != '(')
                        {
                            output += c.ToString() + ' ';
                            c = operatorStore.Pop();
                        }
                    }
                    else
                    {
                        if (operatorStore.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(operatorStore.Peek()))
                                output += operatorStore.Pop().ToString() + " ";

                        operatorStore.Push(char.Parse(input[i].ToString()));
                    }
                }

                
            }

            while (operatorStore.Count > 0)
                output += operatorStore.Pop() + " ";

            return output;
        }
        /// <summary>
        ///  A method that evaluates the value of an expression already postfixed
        /// </summary>
        /// <param name="input"></param>
        /// <returns>return final result</returns>
        private static double Counting(string input)
        {
            double result = 0;
            Stack<double> temp = new Stack<double>();

            for(int i = 0; i < input.Length; i++)
            {
                if(Char.IsDigit(input[i]))
                {
                    string str = string.Empty;

                    while(!IsSeparator(input[i]) && IsOperator(input[i]))
                    {
                        str += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(str));
                    i--;
                }
                else if(IsOperator(input[i]))
                {
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch(input[i])
                    {
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                    }
                    temp.Push(result);
                }
            }

            return temp.Peek();
        }
        /// <summary>
        /// The method returns true if the checked character is a separator ("space" or "equal")
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsSeparator(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        /// <summary>
        /// The method returns true if the character being checked is an operator
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        private static bool IsOperator(char k)
        {
            if (("-/*".IndexOf(k) != -1))
                return true;
            return false;
        }
        /// <summary>
        /// The method returns the precedence of the operator
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static byte GetPriority(char s)
        {
            switch (s)
            {
                case '-': return 0;
                case '*': return 1;
                case '/': return 2;
                default: return 4;
            }
        }
    }
}
