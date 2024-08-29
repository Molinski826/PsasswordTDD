using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    public class NewPass
    {
        public  bool AddPassword(string password, List<string> list)
        {
            if (password.Contains(password))
            {
                return false;
            }
            if(password.Length <= 7 ||  password.Length >= 12)
            {
                return false;
            }
            if (password.Contains(' '))
            {
                return false;   
            }
            int capitalVowel = password.Count( c => "AEIOUY".Contains(c) );
            if(capitalVowel < 2)
            {
                return false;
            }
            if (password == "admin" || password == "mod")
            {
                if (list.Contains(password) == false)
                {
                    list.Add(password);
                    return true;
                }
            }
            return false;
        }
    }
}
