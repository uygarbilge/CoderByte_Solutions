using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeByte_Solutions
{
    public class CodelandUsername
    {

        public static string CodelandUsernameValidation(string str)
        {

            //ASCI code A-Z   65-90
            //ASCI code a-z   97-122

            if (str.Length < 4 || str.Length > 24)
                return "false";

            //it must start with a letter
            if (  !(str[0] >= 65 && str[0] <=90 ) &&
                  !(str[0] >= 97 && str[0] <= 122) )
            {
                return "false";
            }

           bool allAlphaNumeric = str.All( x => char.IsLetterOrDigit( x ) || x == '_' );

            if ( !allAlphaNumeric ) { 
                return "false"; 
            }

            if (str[str.Length -1] == '_' ) {
                return "false";
            }

            // code goes here  
            return "true";

        }

        public void Run()
        {
            CodelandUsernameValidation("u__hello_world123");

        }
    }
}
