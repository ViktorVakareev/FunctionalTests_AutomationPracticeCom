using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalTests_AutomationPracticeCom
{
    public static class UrlDeterminer
    {
        public static string GetEbayUrl(string urlPart)
        {
            string url = Path.Combine(ConfigurationService.Instance.GetUrlSettings().EbayUrl, urlPart).ToString();
            return url;
        }
        public static string GetMainDressesPageUrl(string urlPart)
        {
            string url = Path.Combine(ConfigurationService.Instance.GetUrlSettings().MainDressesPage, urlPart).ToString();
            return Url.Create(url).ToString();
        }
        //public static string GetAmazonUrl(string urlPart)
        //{
        //    return Url.Combine(ConfigurationService.Instance.GetUrlSettings().AmazonUrl, urlPart).ToString();
        //}
        //public static string GetKindleUrl(string urlPart)
        //{
        //    return Url.Combine(ConfigurationService.Instance.GetUrlSettings().KindleUrl, urlPart).ToString();
        //}
    }
}
