
using System;
using System.Collections.Generic;
using System.Text;

namespace CsUtility.Primitive
{
    public static partial class PrimitiveUtilities
    {

        /// <summary>
        /// 指定した値が非数値 (<see cref="float.NaN"/>) かどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が非数 (<see cref="float.NaN"/>) と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsNaN(this float val)
        {
            return float.IsNaN(val);
        }


        /// <summary>
        /// 指定した値が負または正の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="float.PositiveInfinity"/> または <see cref="float.NegativeInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsInfinity(this float val)
        {
            return float.IsInfinity(val);
        }


        /// <summary>
        /// 指定した値が正の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="float.PositiveInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsPositiveInfinity(this float val)
        {
            return float.IsPositiveInfinity(val);
        }


        /// <summary>
        /// 指定した値が負の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="float.NegativeInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsNegativeInfinity(this float val)
        {
            return float.IsNegativeInfinity(val);
        }


        /// <summary>
        /// 指定した値が非数値 (<see cref="double.NaN"/>) かどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が非数 (<see cref="double.NaN"/>) と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsNaN(this double val)
        {
            return double.IsNaN(val);
        }


        /// <summary>
        /// 指定した値が負または正の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="double.PositiveInfinity"/> または <see cref="double.NegativeInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsInfinity(this double val)
        {
            return double.IsInfinity(val);
        }


        /// <summary>
        /// 指定した値が正の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="double.PositiveInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsPositiveInfinity(this double val)
        {
            return double.IsPositiveInfinity(val);
        }


        /// <summary>
        /// 指定した値が負の無限大と評価されるかどうかを示す値を返します。
        /// </summary>
        /// <param name="val"> 評価する値。 </param>
        /// <returns>
        /// <paramref name="val"/> が <see cref="double.NegativeInfinity"/> と評価される場合は true。それ以外の場合は false。
        /// </returns>
        public static bool IsNegativeInfinity(this double val)
        {
            return double.IsNegativeInfinity(val);
        }

    }
}
