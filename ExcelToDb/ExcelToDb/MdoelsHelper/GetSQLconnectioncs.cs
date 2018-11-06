using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net.Sockets;
using GetSqlconn.Models;

namespace ExcelToDb.MdoelsHelper
{
    
    /// <summary>
    /// 获取数据库连接字符串
    /// </summary>
    public class GetSQLconnectioncs
    {
        SecurityHelper sh = new SecurityHelper();
        private string APIUrl = ConfigurationManager.AppSettings["APIAddress"];
        private string _Code = "";
        private string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        private string _Md5Pass = "";
        private string Md5Pass
        {
            get { return _Md5Pass; }
            set { _Md5Pass = value; }
        }
        private string _SignKey = "";
        private string SignKey
        {
            get { return _SignKey; }
            set { _SignKey = value; }
        }
        public GetSQLconnectioncs(string Code,string Md5Pass,string SignKey)
        {
            this.Code = Code;
            this.Md5Pass = Md5Pass;
            this.SignKey = SignKey;
        }
        public static string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < IpEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        return IpEntry.AddressList[i].ToString();
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string WebGetConnection()
        {
            string Paramstr = string.Format(@"QueryType={0}&Code={1}&Sign={2}&Time={3}&IP={4}",
                "GetConnection", Code, sh.HMACSMD5Encrypt(Code + Md5Pass + DateTime.Now.ToString("yyyyMMdd"), SignKey,Encoding.UTF8).ToLower(),DateTime.Now.ToString(),GetLocalIP());
            string Url = APIUrl;
            string Result = WebPost(Url,Paramstr);
            return Result;
        }
        private string WebPost(string url, string Paramsstr)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            /*
             * application/x-www-form-urlencoded含义是表示客户端提交给服务器文本内容的编码方式 是URL编码
             * 
             * charset=utf-8的意思是：Accept-Encoding，HTTP Header中Accept-Encoding 是浏览器发给服务器,
             * 声明浏览器支持的编码类型
             * 
             */
            req.ContentType = "application/x-www-form-urlencoded;";
            #region 添加Post 参数
            byte[] data = Encoding.UTF8.GetBytes(Paramsstr);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream))
            {
                result = reader.ReadToEnd();
            }
            return System.Web.HttpUtility.UrlDecode(result,Encoding.UTF8);
        }
    }
}
