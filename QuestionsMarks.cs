using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class QuestionsMarks_
    {

        public static string QuestionsMarks(string str)
        {
            List<char> listStr = str.ToCharArray().ToList();

            bool sum10exists = false;

            for(int i = 0; i < listStr.Count-4; i++) 
            { 
                for( int j = i + 4; j <= listStr.Count - 1; j ++)
                {
                    //check if both i and j are numbers

                    bool isINumber = Char.IsDigit(listStr[i]);
                    bool isJNumber = Char.IsDigit(listStr[j]);

                    //find the substring between i and j

                    if( isINumber && isJNumber)
                        if( Int32.Parse(listStr[i].ToString()) + Int32.Parse(listStr[j].ToString()) == 10)
                        {
                            //if there is any digit between them, ignore the case
                            if(!HasDigit ( str.Substring(i+1, (j - i-1))))
                            {
                                bool hasThreeMarks = ContainsThreeQuestionMarks(str.Substring(i, (j - i + 1)));

                                if (!hasThreeMarks)
                                    return "false";
                                else
                                    sum10exists = true;
                            } 
                       
                        } 
                }
            }

           if(!sum10exists)
            {
                return "false";
            }

            return "true";

        }

        public static bool HasDigit(string str)
        {
            bool containsInt = str.Any(char.IsDigit);
            return containsInt;
        }

        //Does the string have exactly 3 question marks
        public static bool ContainsThreeQuestionMarks(string str) {

            Console.WriteLine(str);

            int count = 0;

            for(int i=0; i < str.Length;i++)
            {
                if (str[i] == '?')
                    count++;
            }

            if (count == 3)
                return true;
            else
                return false;

        }

        public void Run()
        {
            QuestionsMarks("9???1???9???1???9");
        } 

    } 
  
}
