using System.Text.RegularExpressions;

namespace QLNS28
{
    public static class RegexCheck
    {
        public static bool Regexp(string re, string chuoi)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(chuoi))
            {
                return true;
            }
            return false;
        }

        public static bool checkMail(this string chuoicheck)
        {
            if (Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", chuoicheck)) return true;
            return false;
        }

        public static bool checksdt(this string chuoicheck)
        {
            if (Regexp(@"^(0011)(([ ][0-9]{3}){3})$", chuoicheck)) return true;
            return false;
        }

        public static bool checkWeb(this string chuoicheck)
        {
            if (Regexp(@"^(http://www\.)([\w]+)\.([\w]+)$$", chuoicheck)) return true;
            return false;
        }

        public static bool checkDate(this string chuoicheck)
        {
            if (Regexp(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$", chuoicheck)) return true;
            return false;
        }

        public static bool checkLength(this string Text)
        {
            if (Text.Length >= 6) return true;
            return false;
        }

        public static bool checknull(this string Text)
        {
            if (Text.Length > 0) return true;
            return false;
        }
    }
}