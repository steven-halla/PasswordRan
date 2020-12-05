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

        }
        //this is how we loop through the entire alphabet to 
        static void addCharss(ref List<char> chars)
        {
            for (char c = "a"; c <= "z"; c++)
            {
                chars.Add(c);
            }
        }
        
    }
}
