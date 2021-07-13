using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace AesCryptoLib.DLL.Controller
{
    public class CryptoManager
    {
        //TODO выбирать закрытый ключ из БД
        private string _encryptionKey = "asf56hjk";
        private byte[] _salt;

        public CryptoManager()
        {
            this._salt = GenerateSalt(15);
        }

        private byte[] GenerateSalt(int size)
        {
            Random rand = new Random();
            byte[] IV = new byte[size];
            rand.NextBytes(IV);
            return IV;
        }

        public string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(_encryptionKey, _salt);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(_salt) + Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public string Decrypt(string codedText)
        {
            byte[] codedSalt = Convert.FromBase64String(codedText.Substring(0, 20));
            codedText = codedText.Substring(20).Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(codedText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(_encryptionKey, codedSalt);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    codedText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return codedText;
        }
    }
}
