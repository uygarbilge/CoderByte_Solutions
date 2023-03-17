using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class MinWindowSubstring_
    {
        public  string MinWindowSubstring(string[] strArr)
        {

            string str = strArr[0];
            string key = strArr[1];

            int strLength = str.Length;
            int keyLength = key.Length;

            string result = string.Empty;

            int currentMinlength = 10000; //dummy large number

        //    Console.WriteLine(str.Substring(1,4));

            for(int i = 0; i < strLength-1; i++)
            {
                for(int j= 1; i+ j< strLength + 1 ; j++)
                {
                   string sub = (str.Substring(i, j));

                    if(sub.Length >= keyLength)
                    {
                        if(ContainsAll(sub, key))
                        {
                            if(sub.Length < currentMinlength)
                            {
                                result = sub;
                                currentMinlength = sub.Length;
                            }
                        }
                    }
                }
            }

            return result;

        }

        public bool ContainsAll(string str, string key)
        {

            List<char> listStr = str.ToCharArray().ToList();
            List<char> listKey = key.ToCharArray().ToList();

            for (int i = 0; i < key.Length; i++)
            {
                if (listStr.Contains(listKey[i]))
                {
                    listStr.Remove(listKey[i]);
                }
                else
                    return false;
            }
             
            return true;
        }

        public void Run()
        {

            string[] strArr = { "aabdccdbcacd", "aad" };
            // keep this function call here
            Console.WriteLine(MinWindowSubstring(strArr));

        }
    }
}
