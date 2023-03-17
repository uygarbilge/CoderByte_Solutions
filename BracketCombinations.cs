using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class BracketCombinations_
    {

        public static int Catalan(int n)
        {
            int res = 0;

            if (n <= 1) { return 1; }

            for (int i = 0; i < n; i++)
                res += Catalan(i) * Catalan(n - i - 1);

            return res;
        }

        public static int BracketCombinations(int num)
        {
            return Catalan(num);
        }

        public void Run()
        {
            int result = BracketCombinations(8);
        }  
    }  
}
