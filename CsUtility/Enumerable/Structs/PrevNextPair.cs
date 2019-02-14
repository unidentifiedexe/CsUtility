using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Enumerable
{
    public static partial class EnumerableUtilities
    {
        /// <summary>
        /// 前後をひとまとめにした構造体
        /// </summary>
        /// <typeparam name="T"> 要素の型。 </typeparam>
        public struct PrevNextPair<T>
        {
            /// <summary> 前方の要素。</summary>
            public T Prev { get; }

            /// <summary> 後方の要素。</summary>
            public T Next { get; }

            internal PrevNextPair(T prev, T next)
            {
                Prev = prev;
                Next = next;
            }

            /// <summary> 前後の要素の分解を行います </summary>
            /// <param name="prev"> 前方の要素。</param>
            /// <param name="next"> 後方の要素。</param>
            public void Deconstruct(out T prev, out T next) => (prev, next) = (Prev, Next);

        }

    }
}
