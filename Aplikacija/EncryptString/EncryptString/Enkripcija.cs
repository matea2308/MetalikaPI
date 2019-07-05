using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EncryptString
{
    public class Enkripcija
    {
        /// <summary>
        /// Metoda koja se koristi za enkripciju stringa/teksta
        /// uz pomoću AES enkriptora (System.Security.Cryptography library)
        /// </summary>
        /// <param name="stringZaEnkripciju">string koji želimo enkriptirati</param>
        /// <param name="kljuc">ključ enkripcije</param>
        /// <returns>enkriptirani string</returns>
        public static string Enkriptiranje(string stringZaEnkripciju, string kljuc)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(stringZaEnkripciju);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(kljuc, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                    }
                    stringZaEnkripciju = Convert.ToBase64String(ms.ToArray());
                }
            }
            return stringZaEnkripciju;
        }

        /// <summary>
        /// Metoda koja se koristi za dekripciju stringa/teksta
        /// uz pomoću AES enkriptora (System.Security.Cryptography library)
        /// </summary>
        /// <param name="stringZaDekripciju">string koji želimo dekriptirati</param>
        /// <param name="kljuc">ključ enkripcije</param>
        /// <returns>dekriptirani string</returns>
        public static string Dekriptiranje(string stringZaDekripciju, string kljuc)
        {
            stringZaDekripciju = stringZaDekripciju.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(stringZaDekripciju);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(kljuc, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                    }
                    stringZaDekripciju = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return stringZaDekripciju;
        }
    }
}
