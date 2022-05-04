using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Gatlin.Utils.Encoding
{
    public class MD5Core
    {
        /// <summary>
        /// MD5加密字符串（32位大写）
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string ToMD5(string source)
        {
            var md5 = new MD5CryptoServiceProvider();
            var bytes = System.Text.Encoding.UTF8.GetBytes(source);
            var result = BitConverter.ToString(md5.ComputeHash(bytes));
            return result.Replace("-", "");
        }

        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="fs"></param>
        /// <returns></returns>
        public static string GetFileMD5(FileStream fs)
        {

            var md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(fs);

            var sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();

        }

        /// <summary>
        /// 获取文件MD5值
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetFileMD5(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return GetFileMD5(fs);
            }
        }
    }
}
