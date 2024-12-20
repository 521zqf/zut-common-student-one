using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skystreampredict
{
    internal class Weather
    {
        //static readonly string Host = " https://sapi.k780.com/?app=weather.wtype";
       // static readonly string Key = "74991";
       // static readonly string sign = "8ffd733adbca522bf3cbcbe34fd62065";
    
            public string success { get; set; }
            public string msg { get; set; }
            public Result result { get; set; }
        

        public class Result
        {
            public string days { get; set; }
            public string week { get; set; }
            public string weather_curr { get; set; }
            public string temp_high { get; set; }
            public string temp_low { get; set; }
            public string citynm { get; set; }
            public string weather_iconid { get; set; }

        }

        // 构造函数

        // https://sapi.k780.com/?app=weather.today&cityId=101201001&appkey=74991&sign=8ffd733adbca522bf3cbcbe34fd62065&format=json static void Main() {
        //string url = GenerateUrl(Key, Location);
        //Console.WriteLine(url);
        //}

    }
}
