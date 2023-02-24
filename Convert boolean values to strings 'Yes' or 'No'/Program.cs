using System;

namespace Convert_boolean_values_to_strings__Yes__or__No__
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static string boolToWord(bool word)
        {
            if (word == true)          
                return "Yes";
            
            else          
                return "No";
            
        }
    }
}
