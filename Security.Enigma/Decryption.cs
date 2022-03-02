using System.Text;
using System.Security.Cryptography;

namespace Security.Enigma
{
    public class Decryption
    {
        public static string DecryptTextInput(string encrypt, string haskKey)
        {
            using (TripleDES tripleDesService = TripleDES.Create())
            {
                using (MD5 hashMD5Service = MD5.Create())
                {
                    byte[] byteHash = hashMD5Service.ComputeHash(Encoding.UTF8.GetBytes(haskKey));
                    tripleDesService.Key = byteHash;
                    tripleDesService.Mode = CipherMode.ECB;
                    byte[] data = Convert.FromBase64String(encrypt);
                    return Encoding.UTF8.GetString(tripleDesService.CreateDecryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
    }
}
