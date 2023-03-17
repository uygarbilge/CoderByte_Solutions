using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class FirstReverse_
    {

        public static string FirstReverse(string str)
        {
            StringBuilder stringBuilder= new StringBuilder();

            for(int i = str.Length -1; i >= 0; i--) {

                stringBuilder.Append(str[i]);
            }

            // code goes here  
            string result = stringBuilder.ToString();

            return result;

        }

        public void Run()
        {
            FirstReverse("I love code.");
        }  
    }  
}
