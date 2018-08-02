using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;


namespace Translator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            




            ResourceManager rm = new ResourceManager("Translator.App_GlobalResources.GlobalResource.de",
                Assembly.GetExecutingAssembly());
            List<string> res = new List<string>();

            ResourceSet resourceSet = rm.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                object resource = entry.Value;
                res.Add(resourceKey + "|" + (string)resource);
                
            }

            res.Sort();

















            //String strWebsite = rm.GetString("ABOUT", CultureInfo.CurrentCulture);
            //String strName = rm.GetString("ACTIVITIES");


            //TranslateText("Hi there, i am looking for a white cat.", "en|de");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public string TranslateText(string inputtext, string languageselector)
        {
            string languagePair = "en|de";
            switch (languageselector.ToUpper())
            {
                case "ENGLISH": languagePair = "en|en"; break;
                case "GERMAN": languagePair = "en|de"; break;
                case "SPANISH": languagePair = "en|es"; break;
                case "FRENCH": languagePair = "en|fr"; break;
                case "DUTCH": languagePair = "en|nl"; break;
                case "SWEDISH": languagePair = "en|sv"; break;
                case "URDU": languagePair = "en|ur"; break;
            }

            inputtext = inputtext.Replace("&", "▓");
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", inputtext, languagePair);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            string result = webClient.DownloadString(url);
            //result = result.Substring(result.IndexOf("id=result_box") + 22, result.IndexOf("id=result_box") + 500);

            int sIndex = 1;
            string _result = "";
            while (sIndex > 0)
            {
                sIndex = result.IndexOf("backgroundColor='#fff'");
                if (sIndex < 0)
                {
                    break;
                }
                result = result.Substring(sIndex + 24, result.Length - sIndex - 24);
                //result = result.Replace("<span>", "").Replace("</span>", "").Replace("<span title =\\", "");
                _result += result.Substring(0, result.IndexOf("</span"));
            }

            return _result.Replace("<br>", "").Replace("</br>", "").Replace("<br />", "").Replace("&#9619;", "&");


        }
    }
}