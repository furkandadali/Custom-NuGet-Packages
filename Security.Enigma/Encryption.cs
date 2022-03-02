using System.Text;
using System.Security.Cryptography;

namespace Security.Enigma
{
    public class Encryptions
    {
        public static string EncryptTextInput(string source,string haskKey)
        {
            using (TripleDES tripleDesService = TripleDES.Create())
            {
                using (MD5 hashMD5Service = MD5.Create())
                {
                    byte[] byteHash = hashMD5Service.ComputeHash(Encoding.UTF8.GetBytes(haskKey));
                    tripleDesService.Key = byteHash;
                    tripleDesService.Mode = CipherMode.ECB;
                    byte[] data = Encoding.UTF8.GetBytes(source);
                    return Convert.ToBase64String(tripleDesService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
    }
}
