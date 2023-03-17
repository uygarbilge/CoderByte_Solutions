using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class LongestWord_
    {
        public static string LongestWord(string sen)
        {
            //ASCI code A-Z   65-90
            //ASCI code a-z   97-122

            List<string> words = sen.Split(' ').ToList();

            string resultWord = string.Empty;
            int wordLength = 0;


            foreach(string word in words)
            {

                if (word.Length > wordLength)
                {
                    //check if it is a word

                    bool isWord = true;

                    for (int k = 0; k < word.Length; k++)
                    {
                        if (((word[k] < 65 || word[k] > 90) &&
                             (word[k] < 97 || word[k] > 122)) && !char.IsDigit(word[k]))
                        {
                            isWord = false; 
                            break;
                        }
                    }

                    if (isWord)
                    {
                        wordLength = word.Length;
                        resultWord = word;
                    }
                }
            }
             
            return resultWord;

        }


        public void Run()
        {
            LongestWord("I love dogs very much");
        }  
    }  
}
