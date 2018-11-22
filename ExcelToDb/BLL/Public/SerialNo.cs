using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BLL.Public
{
    /// <summary>
    /// 流水号生成-功能类
    /// </summary>
    public class SerialNo
    {
        /// <summary>
        /// 生成基于时间的20位数字流水号
        /// </summary>
        /// <returns></returns>
        public string CreateSerialNo()
        {
            string TimeNo = DateTime.Now.ToString("yyyyMMddHHmmssms");
            System.Random random = new System.Random();
            TimeNo += random.Next(10, 99);
            return TimeNo;
        }
        /// <summary>
        /// 基于时间戳（long）+原子操作生成的13位流水号
        /// </summary>
        /// <returns></returns>
        public string CreateGenerator()
        {
            long seed = long.Parse(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds.ToString("0"));
            Interlocked.Increment(ref seed);
            return seed.ToString();
        }
    }
}
