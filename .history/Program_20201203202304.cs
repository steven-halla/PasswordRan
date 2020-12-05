using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PasswordRan
{
    public class Program
    {
        static List<char> chars= new List<char>();

        static void Main(string[] args)
        {
            addChars(ref chars);
            
        }
        static string generatePassword(int length)
        {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            int j = 0;

            while (j < length)
            {
                sb.Append(chars[rand.next(0,chars.Count)]);
                j++;
            }

            return sb.ToString
        }
        //this is how we loop through the entire alphabet 
        static void addCharss(ref List<char> chars)
        {
            for (char c = "a"; c <= "z"; c++)
            {
                chars.Add(c);
            }

            for (char c = "A"; c <= "Z"; c++)
            {
                chars.Add(c);
            }

            for (char c = "1"; c <= "9"; c++)
            {
                chars.Add(c);
            }

        }
        
    }
}
