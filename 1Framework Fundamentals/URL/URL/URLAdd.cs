using System;
using System.Text;

namespace URL
{
    public class URLAdd
    {
        public string AddOrChangeUrlParameter(string url, string keyValue)
        {
            if (url == null || keyValue == null)
                throw new ArgumentNullException("The transmitted string must not be null.");

            StringBuilder sb = new StringBuilder();
            sb.Append(url);

            int pos = sb.ToString().IndexOf(keyValue);
            if ((url.Contains(keyValue) == true) && pos >= 0)
            {
                sb.Remove(pos, keyValue.Length);
            }
            else
            {
                sb.Append(keyValue);
            }

            return sb.ToString();
        }
    }
}
