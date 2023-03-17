using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class BracketMatcher_
    {
        public static string BracketMatcher(string str)
        {
            //default result value is true since there may be no brackets at all
            bool result = true;

            Stack<char> stack = new Stack<char>();


            for(int i = 0; i < str.Length; i ++)
            {
                if (str[i] == '(')
                    stack.Push(str[i]);

                else if (str[i] == ')')
                {
                    if(stack.Count == 0)
                    {
                        result = false;
                        return "0";
                    }
                    if(stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                       
                }
            }

          if(stack.Count != 0)
                result = false;

            if (result)
                return "1";
            else
                return "0";

        }


        public void Run()
        {
            BracketMatcher("((adf))");
        } 

    }   
}
