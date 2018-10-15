using Jil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace GTranslator.Services
{
    public class LanguagePair
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public interface ITranslatorService
    {
        IList<LanguagePair> Languages { get; set; }

        string InputLanguage { get; set; }

        string OutputLanguage { get; set; }

        string TranslateAsync(string Content);
    }

    public class Translator : ITranslatorService
    {
        public IList<LanguagePair> Languages { get; set; }

        public string InputLanguage { get; set; }

        public string OutputLanguage { get; set; }

        private static HttpClient Browser { get; set; }

        static Translator()
        {
            Browser = new HttpClient
            {
                BaseAddress = new Uri("https://translate.google.com")
            };

            Browser.DefaultRequestHeaders.Accept.Clear();
            Browser.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Browser.DefaultRequestHeaders
                .Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:63.0) Gecko/20100101 Firefox/63.0");
            Browser.DefaultRequestHeaders
                .Add("Referer", "https://translate.google.com/");
        }

        public Translator()
        {
            try
            {
                Languages = JSON.Deserialize<List<LanguagePair>>(File.ReadAllText("languages.json"));

                InputLanguage = "auto";
                OutputLanguage = "en";
            }
            catch (Exception e)
            {
                Languages = new List<LanguagePair>();
                Console.WriteLine(e);
            }
        }

        public string TranslateAsync(string Content)
        {
            try
            {
                var Getto = Browser.GetStringAsync(TranslateUri(Content)).Result;

                var Data = (JSON.DeserializeDynamic(Getto))[0];

                var Result = "";

                foreach (var row in Data)
                {
                    Result += ((string)row[0]).Trim('"');
                }

                return Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }

        private string TranslateUri(string Content)
            => string.Format(@"translate_a/single?client=gtx&sl={0}&tl={1}&ie=UTF-8&oe=UTF-8&dt=t&q={2}",
                InputLanguage.ToLower(),
                OutputLanguage.ToLower(),
                HttpUtility.UrlEncode(Content));
    }
}
