/**
 * This class contains some helper methods and analysis options for the cipher text. 
 */

using System;
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
            //convert to lower case
            text = text.ToLower();
            //remove everything except a-z. 
            text = Regex.Replace(text, "[^a-z]", String.Empty); 
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