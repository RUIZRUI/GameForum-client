using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum
{
    public class TimeHelper
    {
        /// <summary>
        /// 时间戳反转为时间
        /// </summary>
        /// <param name="TimeStamp">时间戳</param>
        /// <param name="AccurateToMilliseconds">是否精确到毫秒</param>
        /// <returns>返回一个日期时间</returns>
        public static DateTime GetTime(long TimeStamp, bool AccurateToMilliseconds = false)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            if (AccurateToMilliseconds)
            {
                return startTime.AddTicks(TimeStamp * 10000);
            }
            else
            {
                // AccurateToMilliseconds 为false时，反转评论时间报错
                // 应该是这个是传入的时间戳是否精确到毫秒
                return startTime.AddTicks(TimeStamp * 10000000);
            }

        }
    }
}
