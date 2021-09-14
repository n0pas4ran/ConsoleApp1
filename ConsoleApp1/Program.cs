using  System;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;




namespace bdf
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            string s = "(555)555-1212 (555) 555-1212  555-555-1212 5555551212";
            string pattern = @"\(?\d{3}\-?\)?\s?\d{3}\-?\d{4}";
            // string pattern = @"^\(?\d{3}\)?[\s\-]?\d{3}\-?\d{4}$";
            Regex re = new Regex(pattern);
            MatchCollection matches = re.Matches(s);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}