using System;
using System.Security.Cryptography.Xml;

/**
 * 
 */

namespace CryptoWeb.Models
{
    public class Atbash
    {
        public string encrypted{get;set;}
        /**
         * Encrypts the plaintext. Uses foreach and goes through each char in the string.
         * Subtracts the integer value of 'a' from the char, then subtracts the integer value of z.
         *
         * This gives the corresponding integer of the letter in the alphabet for atbash. This is casted to a char
         * and then concatenated to the encrypted string. 
         */
        public void encrypt(string plaintext)
        {
            plaintext = Analysis.processtext(plaintext); 
            encrypted = ""; 
            foreach (char c in plaintext)
               encrypted += (char)( 'z' - (c - 'a') ); 
        }
        
    }
}