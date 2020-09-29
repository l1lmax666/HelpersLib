using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelpersLib
{
    public static class LoggerHelper
    {
        private static readonly string FilePath = @$"{Environment.CurrentDirectory}\DmeBxApiService\Logs\";

        public async static void Write(string FileName, string Message)
        {
            string tempFileName = $"{FileName}" + DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");

            using (StreamWriter sw = new StreamWriter(FilePath + @$"{tempFileName}.txt", false, System.Text.Encoding.Default))
            {
                await sw.WriteLineAsync(Message);
            }
        }
    }
}
