using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Design;

namespace CryptoWeb.Models
{
    public class Vigenere
    {
        //private string encrypted;
        //private string decrypted;
        //private string key; 
        private Dictionary<char, int> dict = new Dictionary<char, int>();

        //[Key] 
        public string key { get; set; }
        public string encrypted { get; set;  }
        public string decrypted { get; set; }

        public Vigenere(/*string inputDecrypted, string inputEncrypted, string inputKey*/ )
        {
            key = " ";
            encrypted = " ";
            decrypted = " ";
         /*   key = inputKey;
            encrypted = Analysis.processtext(inputEncrypted);
            decrypted = Analysis.processtext(inputDecrypted);
            
            if (string.IsNullOrEmpty(encrypted) && !string.IsNullOrEmpty(key))
            {
               Encrypt(); 
            }
            else if (string.IsNullOrEmpty(decrypted) && !string.IsNullOrEmpty(key))
            {
                Decrypt();
            }*/

        } 

        public void Decrypt()
        {
            int i = 0;
            int ordnumber = 0;
            int j = key.Length;
            foreach (var c in encrypted)
            {
                if (i == j)
                    i = 0;
                ordnumber = (int) c + ((int) key[i] - 97);
                if (ordnumber < 97)
                    ordnumber += 26;
                decrypted += (char) ordnumber;
                i += 1; 
            }
        }

        public void Encrypt()
        {
            int i = 0;
            int ordnumber = 0;
            int j = key.Length;
            foreach (var c in decrypted)
            {
                if (i == j)
                    i = 0;
                ordnumber = (int) c + ((int) key[i] - 97);
                if (ordnumber > 122)
                    ordnumber -= 26;
                encrypted += (char) ordnumber;
                i += 1; 
            }

        }

        //getters and setters for the encrypted text
        public Dictionary<char, int> Dict => dict;

        public string encryptedText
        {
            get => encrypted;
            set => encrypted = value;
        }

        public string decryptedText
        {
            get => decrypted;
            set => decrypted = value;
        }


        
        
    }
}