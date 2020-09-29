using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HelpersLib
{
    public static class JsonHelper
    {
        public static bool IsValid(string source)
        {
            try
            {
                JToken.Parse(source);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
