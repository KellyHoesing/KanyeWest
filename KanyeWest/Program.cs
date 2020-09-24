using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                if(i%2!=0)
                {
                    Kanye.KanyeQuote();
                }
                else
                {
                    Kanye.RonQuote();
                }
            }
        }
    }
}
