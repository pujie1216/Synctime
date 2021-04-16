using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Synctime
{
    public partial class SynctimeForm : Form
    {
        public SynctimeForm()
        {
            InitializeComponent();
            Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void SynctimeForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            if (!localtimebgwk.IsBusy)
            {
                localtimebgwk.RunWorkerAsync();
            }
            if (!unitimebgwk.IsBusy)
            {
                unitimebgwk.RunWorkerAsync();
            }
            if (!jdtimebgwk.IsBusy)
            {
                jdtimebgwk.RunWorkerAsync();
            }
        }

        private void Localtimebgwk_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                localtimeflb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                System.Threading.Thread.Sleep(1);
            }
        }

        private static String Httpors()
        {
            OperatingSystem os = Environment.OSVersion;
            String httpors;
            if (Convert.ToDouble(os.Version.ToString().Substring(0, 3)) < 6.1)
            {
                httpors = "http://";
            }
            else
            {
                httpors = "https://";
            }
            return httpors;
        }

        private static String Urlresp(String url)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "Mozilla/5.0 (Linux;Android 10;GM1910) AppleWebKit/537.36(KHTML, like Gecko) "
                     + "Chrome / 83.0.4103.106 Mobile Safari/ 537.36";
                httpWebRequest.Timeout = 1000;

                String urlresp;
                using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
                {
                    using (StreamReader StreamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        urlresp = StreamReader.ReadToEnd();
                    }
                }

                return urlresp;
            }
            catch (Exception)
            {
                String urlresp = "error";
                return urlresp;
            }
        }

        private void Unitimebgwk_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            String httpors = Httpors();
            String unifritimep = httpors + "m.client.10010.com/welfare-mall-front-activity/mobile/activity/getCurrentTimeMillis/v2";
            while (true)
            {
                String unifritimepr = Urlresp(unifritimep);
                if (unifritimepr != "error")
                {
                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    Dictionary<String, Object> unifritimeprd = (Dictionary<String, Object>)javaScriptSerializer.DeserializeObject(unifritimepr);
                    Object resdata = unifritimeprd["resdata"];
                    Dictionary<String, Object> resdataD = (Dictionary<String, Object>)(resdata);
                    Int64 currentTime = Int64.Parse(resdataD["currentTime"].ToString());
                    unitimeflb.Text = startTime.AddMilliseconds(currentTime).ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
                System.Threading.Thread.Sleep(1);
            }
        }

        private void JDtimebgwk_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            String httpors = Httpors();
            String jdtimep = httpors + "api.m.jd.com/client.action?functionId=queryMaterialProducts&client=wh5";
            while (true)
            {
                String jdtimepr = Urlresp(jdtimep);
                if (jdtimepr != "error")
                {
                    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                    Dictionary<String, Object> jdtimeprd = (Dictionary<String, Object>)javaScriptSerializer.DeserializeObject(jdtimepr);
                    Int64 serverTime = Int64.Parse(jdtimeprd["currentTime2"].ToString());
                    jdtimeflb.Text = startTime.AddMilliseconds(serverTime).ToString("yyyy-MM-dd HH:mm:ss.fff");
                }
                System.Threading.Thread.Sleep(1);
            }
        }

        [DllImportAttribute("Kernel32.dll")]

        public static extern void GetLocalTime(ref SystemTime systemTime);

        [DllImportAttribute("Kernel32.dll")]

        public static extern void SetLocalTime(ref SystemTime systemTime);

        [StructLayout(LayoutKind.Sequential)]
        public struct SystemTime
        {
            public UInt16 sysYear;
            public UInt16 sysMonth;
            public UInt16 sysDayOfWeek;
            public UInt16 sysDay;
            public UInt16 sysHour;
            public UInt16 sysMinute;
            public UInt16 sysSecond;
            public UInt16 sysMilisecond;
        }

        private void SetSystime(String timef)
        {
            DateTime dateTime = Convert.ToDateTime(timef);
            SystemTime systemTime = new SystemTime();
            GetLocalTime(ref systemTime);
            systemTime.sysYear = (UInt16)dateTime.Year;
            systemTime.sysMonth = (UInt16)dateTime.Month;
            systemTime.sysDay = (UInt16)dateTime.Day;
            systemTime.sysHour = (UInt16)dateTime.Hour;
            systemTime.sysMinute = (UInt16)dateTime.Minute;
            systemTime.sysSecond = (UInt16)dateTime.Second;
            systemTime.sysMilisecond = (UInt16)dateTime.Millisecond;
            SetLocalTime(ref systemTime);
        }

        private void Syncunitimebt_Click(object sender, EventArgs e)
        {
            String unitimef = unitimeflb.Text;
            SetSystime(unitimef);
            MessageBox.Show("本地时间已同步联通时间", "提示");
        }

        private void Syncjdtimebt_Click(object sender, EventArgs e)
        {
            String jdtimef = jdtimeflb.Text;
            SetSystime(jdtimef);
            MessageBox.Show("本地时间已同步京东时间", "提示");
        }
    }
}
