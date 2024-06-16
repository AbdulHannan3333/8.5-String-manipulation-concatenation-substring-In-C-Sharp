using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5_String_manipulation__concatenation__substring_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f_name = "Abdul";
            string l_name = "Hannan";
            Console.WriteLine("Full Name: " + f_name + " " + l_name);
            string sentence = "The quick brown fox jumps over the lazy dog";
            string sub = sentence.Substring(4,17);
            Console.WriteLine($"SubString: {sub}");
        }
    }
}
