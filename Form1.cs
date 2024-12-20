using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Globalization;
using System.IO;
using NAudio.Wave;
namespace skystreampredict
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            List<City> comboxs = new List<City>()
            {
                new City(){ cityid="101010100",citynm="北京市",pid=""},
                new City(){ cityid="101200101",citynm="湖北省",pid=""},
                new City(){ cityid="101180101",citynm="河南省", pid="" },
                };
            this.comboBox1.DisplayMember = "citynm";
            this.comboBox1.ValueMember = "cityid";
            this.comboBox1.DataSource = comboxs;
            this.comboBox1.SelectedIndex = 0;
            audioFileReader = new AudioFileReader(@"C:\Users\DELL\Desktop\skystreampredict\Resources\yuzhou.wav");
            waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("man");
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {//bang ding xiala kuang
         //MessageBox.Show("man");
         
            List<City> comboxs2 = new List<City>()
            {
                //beijing
                new City(){ cityid="101010300", citynm="朝阳", pid="101010100" },
                new City(){ cityid="101010400", citynm="顺义", pid="101010100" },
                new City(){ cityid="101010700", citynm="昌平", pid="101010100" },
                new City(){ cityid="101010500", citynm="怀柔", pid="101010100" },
                new City(){ cityid="101010600", citynm="通州", pid="101010100" },
                new City(){ cityid="101010900", citynm="丰台", pid="101010100" },
                new City(){ cityid="101011100", citynm="大兴", pid="101010100" },
                new City(){ cityid="101011200", citynm="房山", pid="101010100" },
                new City(){ cityid="101011300", citynm="密云", pid="101010100" },
                new City(){ cityid="101010200", citynm="海淀", pid="101010100" },
                new City(){ cityid="101011000", citynm="石景山", pid="101010100"},
                //wuhan
                new City(){ cityid="101200101", citynm="武汉", pid="101200101" },
                new City(){ cityid="101200501", citynm="黄石", pid="101200101" },
                new City(){ cityid="101200801", citynm="荆州", pid="101200101" },
                new City(){ cityid="101200901", citynm="宜昌", pid="101200101" },
                new City(){ cityid="101201001", citynm="恩施", pid="101200101" },
                new City(){ cityid="101201101", citynm="十堰", pid="101200101" },
                new City(){ cityid="101201201", citynm="神农架", pid="101200101"},
                new City(){ cityid="101201301", citynm="随州", pid="101200101" },
                new City(){ cityid="101201401", citynm="荆门", pid="101200101" },
                new City(){ cityid="101201501", citynm="天门", pid="101200101" },
                new City(){ cityid="101201601", citynm="仙桃", pid="101200101" },
                new City(){ cityid="101201701", citynm="潜江", pid="101200101" },
                new City(){ cityid="101200201", citynm="襄樊", pid="101200101" },
                new City(){ cityid="101200301", citynm="鄂州", pid="101200101" },
                new City(){ cityid="101200401", citynm="孝感", pid="101200101" },
                new City(){ cityid="101200601", citynm="黄石", pid="101200101" },
                new City(){ cityid="101200701", citynm="咸宁", pid="101200101" },
                //henan
                new City(){ cityid="101180101", citynm="郑州", pid="101180101" },
                new City(){ cityid="101180301", citynm="新乡", pid="101180101" },
                new City(){ cityid="101180401", citynm="许昌", pid="101180101" },
                new City(){ cityid="101180501", citynm="平顶山", pid="101180101" },
                new City(){ cityid="101180601", citynm="信阳", pid="101180101" },
                new City(){ cityid="101180701", citynm="南阳", pid="101180101" },
                new City(){ cityid="101180801", citynm="开封", pid="101180101" },
                new City(){ cityid="101180901", citynm="洛阳", pid="101180101" },
                new City(){ cityid="101181001", citynm="商丘", pid="101180101" },
                new City(){ cityid="101181101", citynm="焦作", pid="101180101" },
                new City(){ cityid="101181201", citynm="鹤壁", pid="101180101" },
                new City(){ cityid="101181301", citynm="濮阳", pid="101180101" },
                new City(){ cityid="101181401", citynm="周口", pid="101180101" },
                new City(){ cityid="101181501", citynm="漯河", pid="101180101" },
                new City(){ cityid="101181601", citynm="驻马店", pid="101180101" },
                new City(){ cityid="101181701", citynm="三门峡", pid="101180101" },
                new City(){ cityid="101181801", citynm="济源", pid="101180101" },
                new City(){ cityid="101180201", citynm="安阳", pid="101180101" }

            };
            this.comboBox2.DisplayMember = "citynm";
            this.comboBox2.ValueMember = "cityid";

            if (this.comboBox1.SelectedValue != null)
            {
                var currlist = comboxs2.Where(p => p.pid == this.comboBox1.SelectedValue.ToString()).ToList();
                this.comboBox2.DataSource = currlist;
                this.comboBox2.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedValue != null)
            {// creature weather
                Weather weather = new Weather();
              //  Weather weatherr= new Weather.();
                week wk=new week(); 
                using (var client = new WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    string url = $"https://sapi.k780.com/?app=weather.today&cityId={this.comboBox2.SelectedValue}&appkey=74991&sign=8ffd733adbca522bf3cbcbe34fd62065&format=json";
                    //download data
                    var data=client.DownloadString(url);
                    //url transform Weather ??means if data is null new create to avoid null
                    weather=JsonConvert.DeserializeObject<Weather>(data)??new Weather();
                }
                
                //dang qian shijian ,wendu ,tianqiqinguang, 
                label5.Text = DateTime.Now.ToString("HH;mm");
                label1.Text = wk.DayOfWeek.ToString();
                if (weather.success == "1")
                {
                    label4.Text = weather.result.weather_curr;
                    label3.Text = weather.result.temp_low+"°C至"+weather.result.temp_high+"°C";
                    pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\logo\\" + weather.result.weather_iconid + ".png");
                }
           //    try
           //    {
           //        // 尝试加载图片的代码
           //        Image image = Image.FromFile("C:\\Users\\DELL\\Desktop\\skystreampredict\\bin\\Debug\\logo\\49.png");
           //        // 其他操作...
           //    }
           //    catch (FileNotFoundException ex)
           //    {
           //        // 处理文件未找到的异常
           //        Console.WriteLine("未能找到文件rrrrrrrrrrrrrr：" + ex.Message);
           //        // 可以在这里添加更多的错误处理逻辑
           //    }



            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    
    }
}