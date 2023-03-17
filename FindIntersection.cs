using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class FindIntersection_
    {
        public static string FindIntersection(string[] strArr)
        {
            List<string> list1 = strArr[0].Split(',').ToList();
            List<string> list2 = strArr[1].Split(',').ToList();

            List<int> list1num = new List<int>();
            List<int> list2num = new List<int>();

            foreach (string str in list1)
                list1num.Add(int.Parse(str));

            foreach (string str in list2)
                list2num.Add(int.Parse(str));

            List<int> resultList = new List<int>();

            foreach (int str in list1num)
            {

                if (list2num.Contains(str))
                {
                    resultList.Add(str);
                }

            }

            if(resultList.Count == 0) {
                return "false";
            }

            string result = string.Empty;

           for(int i = 0; i < resultList.Count; i++)
            {
                result += resultList[i].ToString().Trim();

                if(i != resultList.Count - 1)
                    result += ",";
            }

            return result;
           

        }


        public void Run()
        {
            string[] str = { "5, 6, 9, 11, 12, 16", "4, 6, 7, 11, 16" };
            FindIntersection(str);
        } 

    } 
 
}
