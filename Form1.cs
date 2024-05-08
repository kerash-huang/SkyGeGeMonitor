using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;

namespace SkyGeGe
{
    public partial class Form1 : Form
    {
        private bool monitorStatus = false;
        public bool isLoginSkype = false;
        public string skypeMainUrl = "https://web.skype.com/";
        public string skypeLoginUrl = "https://login.live.com/login.srf";
        public List<string> monitorCidList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            string currentURL = browser.Source.ToString();
            if (currentURL.Equals(skypeMainUrl))
            {
                isLoginSkype = true;
                addInfoMessage("Skype 已登入.");
                browser.Visible = false;
                setMonitorStatus(true);
            }
            else if (currentURL.IndexOf(skypeLoginUrl) >= 0)
            {
                isLoginSkype = false;
                addInfoMessage("登入 Skype 中");
                browser.Visible = true;
                setMonitorStatus(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser.CoreWebView2InitializationCompleted += new EventHandler<CoreWebView2InitializationCompletedEventArgs>(WebView21_CoreWebView2InitializationCompleted);
        }
        private void WebView21_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            browser.CoreWebView2.WebResourceResponseReceived += CoreWebView2_WebResourceResponseReceived;
        }

        private async void CoreWebView2_WebResourceResponseReceived(object? sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            Stream? stream = null;
            TextReader? tr = null;

            try
            {
                stream = await e.Response.GetContentAsync();
                tr = new StreamReader(stream);
                string re = tr.ReadToEnd();
                string pollingUri = e.Request.Uri.ToString();
                if (pollingUri.IndexOf("/subscriptions/0/poll?") >= 0)
                {
                    try
                    {
                        PollingResponse? pollingResponse = JsonConvert.DeserializeObject<PollingResponse>(re);
                        if (pollingResponse != null && pollingResponse.eventMessages != null && pollingResponse.eventMessages.Count > 0 && pollingResponse.eventMessages[0].resourceType.Equals("NewMessage") && pollingResponse.eventMessages[0].resource.type.Equals("Message"))
                        {
                            string senderDisplayName = pollingResponse.eventMessages[0].resource.imdisplayname;
                            string messageContent = pollingResponse.eventMessages[0].resource.content;
                            string groupDisplayName = pollingResponse.eventMessages[0].resource.threadtopic;
                            if (messageContent != null)
                            {
                                addInfoMessage("收到新訊息 [群組名稱: " + groupDisplayName + "] " + senderDisplayName + "\r\n   " + messageContent);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        addInfoMessage(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // addInfoMessage(ex.Message);
            }
            if (stream != null)
            {
                stream.Close();
                stream = null;
            }
            if (tr != null)
            {
                tr.Close();
                tr = null;
            }

        }

        private void addInfoMessage(string message)
        {
            DateTime now = DateTime.Now;
            info_box.AppendText("[" + now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + message + "\r\n");
        }

        private void setMonitorStatus(bool status)
        {
            monitorStatus = status;
            if (monitorStatus)
            {
                ts_menu_item_monitor_status.CheckState = CheckState.Checked;
            }
            else
            {
                ts_menu_item_monitor_status.CheckState = CheckState.Unchecked;
            }
        }

        private void ts_item_setList_Click(object sender, EventArgs e)
        {
            MonitorListSetting monitorListForm = new MonitorListSetting();
            monitorListForm.FormClosing += new FormClosingEventHandler(MonitorListSetting_FormClosing);
            monitorListForm.ShowDialog();
        }

        private void MonitorListSetting_FormClosing(object? sender, FormClosingEventArgs e)
        {
            
        }

        private void btn_startBot_Click(object sender, EventArgs e)
        {
            btn_startBot.Enabled = false;
            addInfoMessage("載入 Skype 中...");
            browser.Source = new Uri(skypeMainUrl);
        }
    }
}
