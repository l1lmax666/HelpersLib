using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HelpersLib
{
    public static class IniHelper
    {
        private static readonly string ConfigPath = @$"{Environment.CurrentDirectory}\DmeBxApiService\DmeConfig.ini";

        public static async Task<bool> SetValue(string key, string value)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ConfigPath, false, System.Text.Encoding.Default))
                {
                    await sw.WriteLineAsync($"{key}={value}");

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetValue(string key)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ConfigPath))
                {
                    string line = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains($"{key}="))
                        {
                            return line.Substring(key.Length + 1);
                        }
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public static bool ConfigExist()
        {
            try
            {
                if (File.Exists(ConfigPath))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool CreateConfig()
        {
            try
            {
                File.Create(ConfigPath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
