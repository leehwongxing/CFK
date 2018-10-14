using System;
using System.Net;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace GTranslator.Views
{
    public partial class API_Translator : Form
    {
        private string FromLanguage = "auto";
        private string ToLanguage;
        public API_Translator()
        {
            InitializeComponent();
            Languages languages = JObject.Parse(File.ReadAllText("languages.json")).ToObject<Languages>();
            cboFrom.Items.Add(new ComboBoxItem("Auto Detect", "auto"));
            foreach (Language lg in languages.languages)
            {
                ComboBoxItem item = new ComboBoxItem(lg.name, lg.language);
                cboFrom.Items.Add(item);
                cboTo.Items.Add(item);
            }
        }
        public void TranslateGoogle(string text)
        {
            if (string.IsNullOrEmpty(ToLanguage))
            {
                MessageBox.Show("Please select languge translate to....");
                return;
            }
            if (string.IsNullOrEmpty(FromLanguage))
            {
                FromLanguage = "auto";
            }
            string url = string.Format(@"https://translate.googleapis.com/translate_a/single?client=gtx&sl={1}&tl={2}&dt=t&q={0}",
                                       HttpUtility.UrlEncode(text), FromLanguage.ToLower(), ToLanguage.ToLower());
            string html = null;
            try
            {
                WebClient web = new WebClient();
                web.Encoding = Encoding.UTF8;
                html = web.DownloadString(url);
                if (html != null)
                {
                    int s1 = html.IndexOf("\"");
                    int s2 = html.IndexOf("\"", s1 + 1);
                    txtResult.Text = html.Substring(s1 + 1, s2 - s1 - 1);
                }
            }
            catch
            {

            }
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                txtResult.Text = "";
                return;
            }
            TranslateGoogle(txtSource.Text);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromLanguage = (((ComboBoxItem)cboFrom.SelectedItem).Value);
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToLanguage = (((ComboBoxItem)cboTo.SelectedItem).Value);
        }
    }
    public class Languages
    {
        public List<Language> languages;
    }
    public class Language
    {
        public string language;
        public string name;
    }
    class ComboBoxItem
    {
        public string Name;
        public string Value;
        public ComboBoxItem(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }

        // override ToString() function
        public override string ToString()
        {
            return this.Name;
        }
    }
}
