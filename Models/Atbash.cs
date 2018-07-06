using System;
using System.Security.Cryptography.Xml;

namespace CryptoWeb.Models
{
    public class Atbash
    {
        public string encrypted{get;set;}
        public void encrypt(string plaintext)
        {
            plaintext = Analysis.processtext(plaintext); 
            encrypted = ""; 
            foreach (char c in plaintext)
               encrypted += (char)( 'z' - (c - 'a') ); 
        }
        
    }
}