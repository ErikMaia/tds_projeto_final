using System;
using System.Collections.Generic;

namespace web.utils
{
    public class SafeArea
    {
        public static bool Test(Dictionary<string, string> cookie)
        {
            if (cookie.ContainsKey("user-id") && !string.IsNullOrEmpty(cookie["user-id"]))
            {
                return true;
            }
            return false;
        }
    }
}
