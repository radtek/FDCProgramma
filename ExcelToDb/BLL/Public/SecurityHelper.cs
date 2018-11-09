using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace BLL.Public
{
    /// <summary>
    /// 安全助手
    /// </summary>
    public sealed class SecurityHelper
    {
        //默认密钥向量--AES 
        private static byte[] _key1 = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF, 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        private  readonly byte[] IvBytes = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };

        #region 通用加密算法

        /// <summary>
        /// 哈希加密算法
        /// </summary>
        /// <param name="hashAlgorithm"> 所有加密哈希算法实现均必须从中派生的基类 </param>
        /// <param name="input"> 待加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        private  string HashEncrypt(HashAlgorithm hashAlgorithm, string input, Encoding encoding)
        {
            var data = hashAlgorithm.ComputeHash(encoding.GetBytes(input));

            return BitConverter.ToString(data).Replace("-", "");
        }

        /// <summary>
        /// 验证哈希值
        /// </summary>
        /// <param name="hashAlgorithm"> 所有加密哈希算法实现均必须从中派生的基类 </param>
        /// <param name="unhashedText"> 未加密的字符串 </param>
        /// <param name="hashedText"> 经过加密的哈希值 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        private  bool VerifyHashValue(HashAlgorithm hashAlgorithm, string unhashedText, string hashedText,
            Encoding encoding)
        {
            return string.Equals(HashEncrypt(hashAlgorithm, unhashedText, encoding), hashedText,
                StringComparison.OrdinalIgnoreCase);
        }

        #endregion 通用加密算法

        #region 哈希加密算法

        #region MD5 算法

        /// <summary>
        /// MD5 加密
        /// </summary>
        /// <param name="input"> 待加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string MD5Encrypt(string input, Encoding encoding)
        {
            return HashEncrypt(MD5.Create(), input, encoding);
        }

        /// <summary>
        /// 验证 MD5 值
        /// </summary>
        /// <param name="input"> 未加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  bool VerifyMD5Value(string input, Encoding encoding)
        {
            return VerifyHashValue(MD5.Create(), input, MD5Encrypt(input, encoding), encoding);
        }

        #endregion MD5 算法

        #region SHA1 算法

        /// <summary>
        /// SHA1 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string SHA1Encrypt(string input, Encoding encoding)
        {
            return HashEncrypt(SHA1.Create(), input, encoding);
        }

        /// <summary>
        /// 验证 SHA1 值
        /// </summary>
        /// <param name="input"> 未加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  bool VerifySHA1Value(string input, Encoding encoding)
        {
            return VerifyHashValue(SHA1.Create(), input, SHA1Encrypt(input, encoding), encoding);
        }

        #endregion SHA1 算法

        #region SHA256 算法

        /// <summary>
        /// SHA256 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string SHA256Encrypt(string input, Encoding encoding)
        {
            return HashEncrypt(SHA256.Create(), input, encoding);
        }

        /// <summary>
        /// 验证 SHA256 值
        /// </summary>
        /// <param name="input"> 未加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  bool VerifySHA256Value(string input, Encoding encoding)
        {
            return VerifyHashValue(SHA256.Create(), input, SHA256Encrypt(input, encoding), encoding);
        }

        #endregion SHA256 算法

        #region SHA384 算法

        /// <summary>
        /// SHA384 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string SHA384Encrypt(string input, Encoding encoding)
        {
            return HashEncrypt(SHA384.Create(), input, encoding);
        }

        /// <summary>
        /// 验证 SHA384 值
        /// </summary>
        /// <param name="input"> 未加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  bool VerifySHA384Value(string input, Encoding encoding)
        {
            return VerifyHashValue(SHA256.Create(), input, SHA384Encrypt(input, encoding), encoding);
        }

        #endregion SHA384 算法

        #region SHA512 算法

        /// <summary>
        /// SHA512 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string SHA512Encrypt(string input, Encoding encoding)
        {
            return HashEncrypt(SHA512.Create(), input, encoding);
        }

        /// <summary>
        /// 验证 SHA512 值
        /// </summary>
        /// <param name="input"> 未加密的字符串 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  bool VerifySHA512Value(string input, Encoding encoding)
        {
            return VerifyHashValue(SHA512.Create(), input, SHA512Encrypt(input, encoding), encoding);
        }

        #endregion SHA512 算法

        #region HMAC-MD5 加密

        /// <summary>
        /// HMAC-MD5 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string HMACSMD5Encrypt(string input, string key, Encoding encoding)
        {
            return HashEncrypt(new HMACMD5(encoding.GetBytes(key)), input, encoding);
        }

        #endregion HMAC-MD5 加密

        #region HMAC-SHA1 加密

        /// <summary>
        /// HMAC-SHA1 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string HMACSHA1Encrypt(string input, string key, Encoding encoding)
        {
            return HashEncrypt(new HMACSHA1(encoding.GetBytes(key)), input, encoding);
        }

        #endregion HMAC-SHA1 加密

        #region HMAC-SHA256 加密

        /// <summary>
        /// HMAC-SHA256 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string HMACSHA256Encrypt(string input, string key, Encoding encoding)
        {
            return HashEncrypt(new HMACSHA256(encoding.GetBytes(key)), input, encoding);
        }

        #endregion HMAC-SHA256 加密

        #region HMAC-SHA384 加密

        /// <summary>
        /// HMAC-SHA384 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string HMACSHA384Encrypt(string input, string key, Encoding encoding)
        {
            return HashEncrypt(new HMACSHA384(encoding.GetBytes(key)), input, encoding);
        }

        #endregion HMAC-SHA384 加密

        #region HMAC-SHA512 加密

        /// <summary>
        /// HMAC-SHA512 加密
        /// </summary>
        /// <param name="input"> 要加密的字符串 </param>
        /// <param name="key"> 密钥 </param>
        /// <param name="encoding"> 字符编码 </param>
        /// <returns></returns>
        public  string HMACSHA512Encrypt(string input, string key, Encoding encoding)
        {
            return HashEncrypt(new HMACSHA512(encoding.GetBytes(key)), input, encoding);
        }

        #endregion HMAC-SHA512 加密

        #endregion 哈希加密算法

        #region 对称加密算法

        #region AES加解密
        /// <summary>
        /// AES加密算法
        /// </summary>
        /// <param name="plainText">明文字符串</param>
        /// <param name="strKey">密钥</param>
        /// <returns>返回加密后的密文字节数组</returns>
        public  string AESEncrypt(string plainText, string strKey)
        {
            //分组加密算法
            SymmetricAlgorithm des = Rijndael.Create();
            byte[] inputByteArray = Encoding.UTF8.GetBytes(plainText);//得到需要加密的字节数组
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            //设置密钥及密钥向量
            des.Key = Encoding.UTF8.GetBytes(strKey);
            des.IV = _key1;
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            byte[] cipherBytes = ms.ToArray();//得到加密后的字节数组
            cs.Close();
            ms.Close();
            //BitConverter.ToString(cipherBytes).Replace("-", "").ToLower()

            return BitConverter.ToString(cipherBytes).Replace("-", "").ToLower();
        }
        public  byte[] ToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="cipherText">密文字节数组</param>
        /// <param name="strKey">密钥</param>
        /// <returns>返回解密后的字符串</returns>
        public  string AESDecrypt(string input, string strKey)
        {
            byte[] cipherText = ToHexByte(input);
            SymmetricAlgorithm des = Rijndael.Create();
            des.Key = Encoding.UTF8.GetBytes(strKey);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            des.IV = _key1;
            byte[] decryptBytes = new byte[cipherText.Length];
            MemoryStream ms = new MemoryStream(cipherText);
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read);
            cs.Read(decryptBytes, 0, decryptBytes.Length);
            cs.Close();
            ms.Close();
            return Encoding.Default.GetString(decryptBytes);
        }
        #endregion

        #region Des 加解密

        /// <summary>
        /// DES 加密
        /// </summary>
        /// <param name="input"> 待加密的字符串 </param>
        /// <param name="key"> 密钥（8位） </param>
        /// <returns></returns>
        public string DESEncrypt(string input, string key)
        {
            try
            {
                var keyBytes = Encoding.UTF8.GetBytes(key);
                //var ivBytes = Encoding.UTF8.GetBytes(iv);

                var des = DES.Create();
                des.Mode = CipherMode.ECB; //兼容其他语言的 Des 加密算法
                des.Padding = PaddingMode.PKCS7; //自动补 0

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
                return null;
            }
        }
        /// <summary>
        /// DES 解密
        /// </summary>
        /// <param name="input"> 待解密的字符串 </param>
        /// <param name="key"> 密钥（8位） </param>
        /// <returns></returns>
        public  string DESDecrypt(string input, string key)
        {
            try
            {
                var keyBytes = Encoding.UTF8.GetBytes(key);
                //var ivBytes = Encoding.UTF8.GetBytes(iv);

                var des = DES.Create();
                des.Mode = CipherMode.ECB; //兼容其他语言的Des加密算法
                des.Padding = PaddingMode.Zeros; //自动补0

                using (var ms = new MemoryStream())
                {
                    var data = Convert.FromBase64String(input);

                    using (var cs = new CryptoStream(ms, des.CreateDecryptor(keyBytes, IvBytes), CryptoStreamMode.Write)
                        )
                    {
                        cs.Write(data, 0, data.Length);

                        cs.FlushFinalBlock();
                    }

                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch
            {
                return input;
            }
        }

        #endregion Des 加解密

        #endregion 对称加密算法

        #region 非对称加密算法

        /// <summary>
        /// 生成 RSA 公钥和私钥
        /// </summary>
        /// <param name="publicKey"> 公钥 </param>
        /// <param name="privateKey"> 私钥 </param>
        public  void GenerateRSAKeys(out string publicKey, out string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                publicKey = rsa.ToXmlString(false);
                privateKey = rsa.ToXmlString(true);
            }
        }

        /// <summary>
        /// RSA 加密
        /// </summary>
        /// <param name="publickey"> 公钥 </param>
        /// <param name="content"> 待加密的内容 </param>
        /// <returns> 经过加密的字符串 </returns>
        public  string RSAEncrypt(string publickey, string content)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publickey);
            var cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);

            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// RSA 解密
        /// </summary>
        /// <param name="privatekey"> 私钥 </param>
        /// <param name="content"> 待解密的内容 </param>
        /// <returns> 解密后的字符串 </returns>
        public  string RSADecrypt(string privatekey, string content)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privatekey);
            var cipherbytes = rsa.Decrypt(Convert.FromBase64String(content), false);

            return Encoding.UTF8.GetString(cipherbytes);
        }

        #endregion 非对称加密算法
        }
}