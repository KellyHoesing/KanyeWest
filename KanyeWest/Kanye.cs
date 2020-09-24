using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Kanye
    {
        public static void KanyeQuote()
        {
            var kanyeURL = "https://api.kanye.rest";
            var client = new HttpClient();
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine($"Kanye: {kanyeQuote}");
        }
        public static void RonQuote()
        {
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var client = new HttpClient();
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine($"Ron: {ronQuote}");
        }
    }
}
