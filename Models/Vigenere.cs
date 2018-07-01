using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace CryptoWeb.Models
{
    public class Vigenere
    {
        private string encrypted;
        private string decrypted;
        private string key; 
        private Dictionary<char, int> dict = new Dictionary<char, int>();

        public Vigenere(string inputDecrypted, string inputEncrypted, string inputKey)
        {
            key = inputKey;
            encrypted = inputEncrypted;
            decrypted = inputDecrypted;
            processtext();
            if (string.IsNullOrEmpty(encrypted))
            {
                //run the encryption method
            }
            else if (string.IsNullOrEmpty(decrypted))
            {
                //run decryption method
            }

        }

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

        void processtext()
        {
            decrypted = decrypted.ToLower();
            Regex rgx = new Regex("^a-zA-Z");
            decrypted = rgx.Replace(decrypted, ""); 
            Regex rgx2 = new Regex(@"r'\s+");
            decrypted = rgx2.Replace(decrypted, "");
        }

        public void letterFreq()
        {
            dict = encrypted.Where(c => char.IsLetter(c)).GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());

        }
        
        
    }
}