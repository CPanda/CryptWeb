/**
 * This class contains some helper methods and analysis options for the cipher text. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CryptoWeb.Models
{
    public class Analysis
    {
        public string encrypted { get; set; }

        public Dictionary<char, int> dict { get; set; }
        
        public List<char> keys { get; set; }
        public List<int> values { get; set;  }
        
        
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
         * Returns a dictionary containing the letter and the number of occurences of that letter.
         * 
         */
        public void stringCounter()
        {
            dict = encrypted.Where(c => char.IsLetter(c)).GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            keys = dict.Select(kvp => kvp.Key).ToList();
            values = dict.Select(kvp => kvp.Value).ToList();

        }
    }
}