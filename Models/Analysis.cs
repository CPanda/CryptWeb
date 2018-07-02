/**
 * This class contains some helper methods and analysis options for the cipher text. 
 */

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CryptoWeb.Models
{
    public class Analysis
    {
        private string encryptedtext; 
        
        
        /**
         * returns a string with removed special characters and spaces for processing. 
         */
        public static string processtext(string text)
        {
            text = text.ToLower();
            Regex rgx = new Regex("^a-zA-Z");
            text = rgx.Replace(text, ""); 
            Regex rgx2 = new Regex(@"r'\s+");
            text = rgx2.Replace(text, "");
            return text; 
        }

        /**
         * Returns a dictionary containing the letter and the number of occurances of that letter.
         * 
         */
        public static Dictionary<char, int> stringCounter(string text)
        {
            Dictionary<char, int> dict = text.Where(c => char.IsLetter(c)).GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            return dict; 

        }
    }
}