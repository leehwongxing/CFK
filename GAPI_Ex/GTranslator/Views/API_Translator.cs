using GTranslator.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GTranslator.Views
{
    public partial class API_Translator : Form
    {
        private Translator EndPoint { get; set; }

        private Timer Clockwork { get; set; }

        private string PreviousState { get; set; }

        //private string FromLanguage = "auto";
        //private string ToLanguage;

        public API_Translator()
        {
            InitializeComponent();

            EndPoint = new Translator();

            Clockwork = new Timer
            {
                Interval = 666,
                Enabled = false,
            };
            Clockwork.Tick += new EventHandler(TikTokMofo);

            CBO_SourceLang.DataSource = new List<LanguagePair>(EndPoint.Languages);
            CBO_TransLang.DataSource = new List<LanguagePair>(EndPoint.Languages);

            //CBO_SourceLang.SelectedIndex = EndPoint.Languages.IndexOf(EndPoint.Languages.Where(x => x.Value == EndPoint.InputLanguage).First());
            //CBO_TransLang.SelectedIndex = EndPoint.Languages.IndexOf(EndPoint.Languages.Where(x => x.Value == EndPoint.OutputLanguage).First());

            //Languages languages = JObject.Parse(File.ReadAllText("languages.json")).ToObject<Languages>();
            //cboFrom.Items.Add(new ComboBoxItem("Auto Detect", "auto"));
            //foreach (Language lg in languages.languages)
            //{
            //    ComboBoxItem item = new ComboBoxItem(lg.name, lg.language);
            //    cboFrom.Items.Add(item);
            //    cboTo.Items.Add(item);
            //}
        }

        private void TikTokMofo(object sender, EventArgs e)
        {
            Clockwork.Stop();

            if (string.IsNullOrWhiteSpace(TX_Source.Text))
            {
                return;
            }

            if (string.Compare(PreviousState, TX_Source.Text) == 0 && sender != null)
            {
                return;
            }

            if (((LanguagePair)CBO_TransLang.SelectedItem).Value == "auto")
            {
                return;
            }

            var Result = EndPoint.TranslateAsync(TX_Source.Text);

            if (string.IsNullOrEmpty(Result))
            {
                MessageBox.Show("Error retrieving translations from Google", "Yeah, this is a feature!!");
            }
            else
            {
                TX_Result.Text = Result.Replace("\n", Environment.NewLine);
                PreviousState = TX_Source.Text;
            }
        }

        //public void TranslateGoogle(string text)
        //{
        //    if (string.IsNullOrEmpty(ToLanguage))
        //    {
        //        MessageBox.Show("Please select languge translate to....");
        //        return;
        //    }
        //    if (string.IsNullOrEmpty(FromLanguage))
        //    {
        //        FromLanguage = "auto";
        //    }
        //    string url = string.Format(@"https://translate.googleapis.com/translate_a/single?client=gtx&sl={1}&tl={2}&dt=t&q={0}",
        //                               HttpUtility.UrlEncode(text), FromLanguage.ToLower(), ToLanguage.ToLower());
        //    string html = null;
        //    try
        //    {
        //        WebClient web = new WebClient();
        //        web.Encoding = Encoding.UTF8;
        //        html = web.DownloadString(url);
        //        if (html != null)
        //        {
        //            int s1 = html.IndexOf("\"");
        //            int s2 = html.IndexOf("\"", s1 + 1);
        //            txtResult.Text = html.Substring(s1 + 1, s2 - s1 - 1);
        //        }
        //    }
        //    catch
        //    {
        //    }
        //}

        private void TX_Source_TextChanged(object sender, EventArgs e)
        {
            Clockwork.Stop();

            if (string.IsNullOrWhiteSpace(TX_Source.Text))
            {
                TX_Result.Clear();
            }
            //TranslateGoogle(txtSource.Text);

            Clockwork.Start();
        }

        private void CBO_SourceLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FromLanguage = ((ComboBoxItem)cboFrom.SelectedItem).Value;
            EndPoint.InputLanguage = ((LanguagePair)CBO_SourceLang.SelectedItem).Value;
            TikTokMofo(null, null);
        }

        private void CBO_TransLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ToLanguage = ((ComboBoxItem)cboTo.SelectedItem).Value;
            EndPoint.OutputLanguage = ((LanguagePair)CBO_TransLang.SelectedItem).Value;
            TikTokMofo(null, null);
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            var Frm_SignIn = new API_SignIn();

            Frm_SignIn.ShowDialog();
        }
    }

    //public class Languages
    //{
    //    public List<Language> languages;
    //}

    //public class Language
    //{
    //    public string language;
    //    public string name;
    //}

    //internal class ComboBoxItem
    //{
    //    public string Name;
    //    public string Value;

    //    public ComboBoxItem(string Name, string Value)
    //    {
    //        this.Name = Name;
    //        this.Value = Value;
    //    }

    //    // override ToString() function
    //    public override string ToString()
    //    {
    //        return this.Name;
    //    }
    //}
}
