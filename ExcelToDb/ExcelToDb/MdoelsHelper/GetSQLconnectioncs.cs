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

namespace ExcelToDb.MdoelsHelper
{
    
    /// <summary>
    /// 获取数据库连接字符串
    /// </summary>
    public class GetSQLconnectioncs
    {
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
        public string WebGetConnection()
        {
            string Paramstr = string.Format(@"QueryType={0}&Code={1}&Sign={2}",
                "GetConnection", Code, PubicHelp.DESEncrypt(Code + Md5Pass, SignKey));
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
            req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
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
            using (StreamReader reader = new StreamReader(stream, Encoding.Default))
            {
                result = reader.ReadToEnd();
            }
            return System.Web.HttpUtility.UrlDecode(result,Encoding.UTF8);
        }
    }
}
