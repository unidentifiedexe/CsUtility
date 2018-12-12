using System;
using System.Collections.Generic;
using System.Text;

namespace CsUtility.Primitive
{
    /// <summary>
    /// 組み込み型の static メソッドの利用を助ける拡張メソッドを提供するクラス。
    /// </summary>
    public static partial class PrimitiveUtilities
    {
        /// <summary>
        /// 指定された文字列が null または System.String.Empty 文字列であるかどうかを示します。
        /// </summary>
        /// <param name="value"> テストする文字列。</param>
        /// <returns> value パラメーターが null または空の文字列 ("") の場合は true。それ以外の場合は false。</returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// 指定された文字列が null または空であるか、空白文字だけで構成されているかどうかを示します。
        /// </summary>
        /// <param name="value"> テストする文字列。</param>
        /// <returns>
        /// value パラメーターが null または System.String.Empty であるか、value が空白文字だけで構成されている場合は。 true
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value); 
        }
    }
}
