
using System;
using System.Collections.Generic;
using System.Text;

namespace CsUtility.Primitive
{
    static partial class PrimitiveUtilities
    {

        public static bool IsNaN(this float val)
        {
            return float.IsNaN(val);
        }


        public static bool IsInfinity(this float val)
        {
            return float.IsInfinity(val);
        }


        public static bool IsPositiveInfinity(this float val)
        {
            return float.IsPositiveInfinity(val);
        }


        public static bool IsNegativeInfinity(this float val)
        {
            return float.IsNegativeInfinity(val);
        }


        public static bool IsNaN(this double val)
        {
            return double.IsNaN(val);
        }


        public static bool IsInfinity(this double val)
        {
            return double.IsInfinity(val);
        }


        public static bool IsPositiveInfinity(this double val)
        {
            return double.IsPositiveInfinity(val);
        }


        public static bool IsNegativeInfinity(this double val)
        {
            return double.IsNegativeInfinity(val);
        }

    }
}
