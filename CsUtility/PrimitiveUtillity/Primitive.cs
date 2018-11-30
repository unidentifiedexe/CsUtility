using System;
using System.Collections.Generic;
using System.Text;

namespace CsUtility.PrimitiveUtillity
{
    static class Primitive
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str); 
        }
    }
}
