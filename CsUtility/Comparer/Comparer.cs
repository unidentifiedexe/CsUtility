using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Comparer
{
    /// <summary> 降順(逆順)に並べ替えるための比較子を提供します。 </summary>
    /// <typeparam name="T"></typeparam>
    public class DescendingComparer<T> : IComparer<T>
    {
        private static DescendingComparer<T> _default;

        private IComparer<T> _base;

        /// <summary>
        /// 汎用引数で指定された型の順序比較子の逆順並べ替えの既定値を返します。
        /// </summary>
        public static DescendingComparer<T> Default
        {
            get
            {
                if (_default == null)
                    _default = new DescendingComparer<T>(Comparer<T>.Default);
                return _default;
            }
        }

        /// <summary> 指定した比較子を使用して、降順の比較子を作成します。 </summary>
        /// <param name="baseComparer"> 基準となる昇順の比較子 </param>
        /// <returns> 生成された降順比較子 </returns>
        public DescendingComparer<T> Create(IComparer<T> baseComparer)
        {
            if (baseComparer == null)
                Error.ArgumentNull(nameof(baseComparer));
            return new DescendingComparer<T>(baseComparer);
        }

        private DescendingComparer(IComparer<T> baseComparer)
        {
            _base = baseComparer;
        }

        int IComparer<T>.Compare(T x, T y)
        {
            return - _base.Compare(x, y);
        }
    }
}
