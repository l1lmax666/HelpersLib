using System;
using System.Collections.Generic;
using System.Text;

namespace HelpersLib
{
    public static class DataFormatting
    {
        public static string Phone(string phone)
        {
            if (phone != null)
            {
                phone = phone.Replace(" ", "");
                phone = phone.Replace("+", "");
                phone = phone.Replace(")", "");
                phone = phone.Replace("(", "");
                phone = phone.Replace("-", "");

                if (phone.Length == 11 && (phone[0] == '7' || phone[0] == '8')) phone.Substring(0, 1);

                return phone;
            }
            else
            {
                return "lol";
            }
        }
    }
}
