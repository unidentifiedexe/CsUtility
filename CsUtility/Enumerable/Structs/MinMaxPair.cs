using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Enumerable
{
    public static partial class EnumerableUtilities
    {        /// <summary> 最小値と最大値の組を持つ構造体。 </summary>
             /// <typeparam name="T"> 要素の型。 </typeparam>
        public struct MinMaxPair<T>
        {
            /// <summary> 最大値。</summary>
            public T Min { get; }

            /// <summary> 最小値。</summary>
            public T Max { get; }

            internal MinMaxPair(T min, T max)
            {
                Min = min;
                Max = max;
            }

            /// <summary> 最大値/最小値の要素の分解を行います。 </summary>
            /// <param name="min"> 最小値の要素。</param>
            /// <param name="max"> 最大値の要素。</param>
            public void Deconstruct(out T min, out T max) => (min, max) = (Min, Max);

        }

    }
}
