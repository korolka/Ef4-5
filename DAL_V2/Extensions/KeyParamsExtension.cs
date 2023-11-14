using DAL_V2.Entity;

namespace DAL_V2.Extensions
{
    public static class KeyParamsExtension
    {
        public static string ToInlineString(this List<KeyParams> keyParams)
        {
            string result = string.Empty;

            foreach (var keyParam in keyParams)
            {
                result += $" {keyParam.KeyWord.Keyword} |";
            }

            return result.TrimEnd('|').TrimEnd(' ').TrimStart(' ');
        }
    }
}