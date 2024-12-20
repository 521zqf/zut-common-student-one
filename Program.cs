using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skystreampredict
{
    
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
     //   [STAThread]
        static void Main()
        {
            //  using (var client = new HttpClient())
            //  {
            //      client.DefaultRequestHeaders.Add("Accept", "application/json");
            //      string url = "https://sapi.k780.com/?app=weather.today&cityId=101201001&appkey=74991&sign=8ffd733adbca522bf3cbcbe34fd62065&format=json";
            //      Weather weather = new Weather();
            //      // 下载数据
            //      try
            //      {
            //          // 下载数据
            //          var data = client.GetStringAsync(url).Result;
            //          // URL transform Weather ? means if data is null new create to avoid null
            //          weather = JsonConvert.DeserializeObject<Weather>(data) ?? new Weather();
            //          Console.WriteLine("Error fetching weather  ");
            //      }
            //      catch (Exception ex)
            //      {
            //          // 处理异常，例如打印错误信息或者显示错误消息
            //          Console.WriteLine("Error fetching weather data: " + ex.Message);
            //      }
            //  }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
