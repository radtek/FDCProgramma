using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToDb.MdoelsHelper
{
    public static class PubicHelp
    {
        private static readonly byte[] IvBytes = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符串</param>
        /// <returns></returns>
        public static string MD5Encrypt(string str)
        {
            string MD5result;
            byte[] result = Encoding.UTF8.GetBytes(str);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            MD5result = BitConverter.ToString(output).Replace("-", "");
            return MD5result;
        }
        /// <summary>
        /// 生成Guid
        /// </summary>
        /// <returns></returns>
        public static string GetNetGuid()
        {
            System.Guid guid = new Guid();
            guid = Guid.NewGuid();
            string str = guid.ToString();
            return str;
        }
        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="input"> 待加密的字符串 </param>
        /// <param name="key"> 密钥（8位） </param>
        /// <returns></returns>
        public static string DESEncrypt(string input, string key)
        {
            try
            {
                var keyBytes = Encoding.UTF8.GetBytes(key);
                //var ivBytes = Encoding.UTF8.GetBytes(iv);

                var des = DES.Create();
                des.Mode = CipherMode.ECB; //兼容其他语言的 Des 加密算法
                des.Padding = PaddingMode.Zeros; //自动补 0

                using (var ms = new MemoryStream())
                {
                    var data = Encoding.UTF8.GetBytes(input);

                    using (var cs = new CryptoStream(ms, des.CreateEncryptor(keyBytes, IvBytes), CryptoStreamMode.Write)
                        )
                    {
                        cs.Write(data, 0, data.Length);
                        cs.FlushFinalBlock();
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch
            {
                return input;
            }
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="input">需要解密的字符串</param>
        /// <param name="key">密匙</param>
        /// <returns></returns>
        public static string DESDecrypt(string input, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Convert.FromBase64String(input);
            des.Key = ASCIIEncoding.ASCII.GetBytes(key);
            des.IV = ASCIIEncoding.ASCII.GetBytes(key);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            // 如果两次密匙不一样，这一步可能会引发异常
            cs.FlushFinalBlock();
            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }
    }
}
