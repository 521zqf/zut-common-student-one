using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skystreampredict
{
    internal class week
    {
        public week()
        {

            // 获取当前日期
            Today = DateTime.Now;

            // 获取中文（中国）的区域信息
            CultureInfo cn = new CultureInfo("zh-CN");

            // 使用中文（中国）的区域信息格式化星期
            DayOfWeek = Today.ToString("dddd", cn);
        }
        public DateTime Today { get; private set; }
        public string DayOfWeek { get; private set; }
    }
}
