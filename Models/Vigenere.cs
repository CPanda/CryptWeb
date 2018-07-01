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
            encrypted = Analysis.processtext(inputEncrypted);
            decrypted = Analysis.processtext(inputDecrypted);
            
            if (string.IsNullOrEmpty(encrypted))
            {
                //run the encryption method
            }
            else if (string.IsNullOrEmpty(decrypted))
            {
                //run decryption method
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