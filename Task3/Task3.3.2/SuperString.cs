using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace epamXT
{
    static class SuperString
    {
        internal enum LanguageList
        {
            Russian,
            English,
            Numbers,
            Mixed
        }
        public static LanguageList CheckLanguage(this string str)
        {
            var charArray = str.ToCharArray();

            if (charArray.All(c => (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я')))
            {
                return LanguageList.Russian;
            }

            else if (charArray.All(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
            {
                return LanguageList.English;
            }

            else if(charArray.All(c => char.IsDigit(c)))
            {
                return LanguageList.Numbers;
            }

            else
            {
                return LanguageList.Mixed;
            }
        }
    }
}
