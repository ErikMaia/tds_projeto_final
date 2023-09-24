using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web.utils;
public class SafeArea
{
    public static bool safeAreaTest(string[] cookie)
    {
        if (cookie["user-id"] != "")
        {
            return true;
        }
        return false;
    }
}
