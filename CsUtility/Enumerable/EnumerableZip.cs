
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CsUtility;


namespace CsUtility.Enumerable
{

    public static partial class EnumerableUtilities
    {
	
        /// <summary>
        /// 指定された関数を結果のシーケンスを生成する 3 個のシーケンスに対応する要素に適用します。
        /// </summary>
        /// <typeparam name="TFirst"> 1 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TSecond"> 2 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TThird"> 3 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TResult"> 結果のシーケンスの要素の型。 </typeparam>
        /// <param name="first"> マージする 1 番目のシーケンス。</param>
        /// <param name="second"> マージする 2 番目のシーケンス。</param>
        /// <param name="third"> マージする 3 番目のシーケンス。</param>
        /// <param name="resultSelector"> 3 個のシーケンスから要素を結合する方法を指定する関数。 </param>
        /// <returns> 3 個の入力シーケンスの結合の要素を格納します </returns>
        /// <exception cref="ArgumentNullException"> 入力シーケンスまたは  が null です。 </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TThird, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            Func<TFirst, TSecond, TThird, TResult> resultSelector)
        {
            if (first == null)  throw Error.ArgumentNull(nameof(first));
            if (second == null)  throw Error.ArgumentNull(nameof(second));
            if (third == null)  throw Error.ArgumentNull(nameof(third));
            if (resultSelector == null)  throw Error.ArgumentNull(nameof(resultSelector));
            return ZipIterator(first, second, third, resultSelector);
        }

        private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TThird, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            Func<TFirst, TSecond, TThird, TResult> resultSelector)
        {
            using (IEnumerator<TFirst> e1 = first.GetEnumerator())
            using (IEnumerator<TSecond> e2 = second.GetEnumerator())
            using (IEnumerator<TThird> e3 = third.GetEnumerator())
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
                    yield return resultSelector(e1.Current, e2.Current, e3.Current);
        }
	
        /// <summary>
        /// 指定された関数を結果のシーケンスを生成する 4 個のシーケンスに対応する要素に適用します。
        /// </summary>
        /// <typeparam name="TFirst"> 1 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TSecond"> 2 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TThird"> 3 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TFourth"> 4 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TResult"> 結果のシーケンスの要素の型。 </typeparam>
        /// <param name="first"> マージする 1 番目のシーケンス。</param>
        /// <param name="second"> マージする 2 番目のシーケンス。</param>
        /// <param name="third"> マージする 3 番目のシーケンス。</param>
        /// <param name="fourth"> マージする 4 番目のシーケンス。</param>
        /// <param name="resultSelector"> 4 個のシーケンスから要素を結合する方法を指定する関数。 </param>
        /// <returns> 4 個の入力シーケンスの結合の要素を格納します </returns>
        /// <exception cref="ArgumentNullException"> 入力シーケンスまたは  が null です。 </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TThird, TFourth, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            IEnumerable<TFourth> fourth,
            Func<TFirst, TSecond, TThird, TFourth, TResult> resultSelector)
        {
            if (first == null)  throw Error.ArgumentNull(nameof(first));
            if (second == null)  throw Error.ArgumentNull(nameof(second));
            if (third == null)  throw Error.ArgumentNull(nameof(third));
            if (fourth == null)  throw Error.ArgumentNull(nameof(fourth));
            if (resultSelector == null)  throw Error.ArgumentNull(nameof(resultSelector));
            return ZipIterator(first, second, third, fourth, resultSelector);
        }

        private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TThird, TFourth, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            IEnumerable<TFourth> fourth,
            Func<TFirst, TSecond, TThird, TFourth, TResult> resultSelector)
        {
            using (IEnumerator<TFirst> e1 = first.GetEnumerator())
            using (IEnumerator<TSecond> e2 = second.GetEnumerator())
            using (IEnumerator<TThird> e3 = third.GetEnumerator())
            using (IEnumerator<TFourth> e4 = fourth.GetEnumerator())
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
                    yield return resultSelector(e1.Current, e2.Current, e3.Current, e4.Current);
        }
	
        /// <summary>
        /// 指定された関数を結果のシーケンスを生成する 5 個のシーケンスに対応する要素に適用します。
        /// </summary>
        /// <typeparam name="TFirst"> 1 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TSecond"> 2 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TThird"> 3 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TFourth"> 4 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TFifth"> 5 番目の入力シーケンスの要素の型。 </typeparam>
        /// <typeparam name="TResult"> 結果のシーケンスの要素の型。 </typeparam>
        /// <param name="first"> マージする 1 番目のシーケンス。</param>
        /// <param name="second"> マージする 2 番目のシーケンス。</param>
        /// <param name="third"> マージする 3 番目のシーケンス。</param>
        /// <param name="fourth"> マージする 4 番目のシーケンス。</param>
        /// <param name="fifth"> マージする 5 番目のシーケンス。</param>
        /// <param name="resultSelector"> 5 個のシーケンスから要素を結合する方法を指定する関数。 </param>
        /// <returns> 5 個の入力シーケンスの結合の要素を格納します </returns>
        /// <exception cref="ArgumentNullException"> 入力シーケンスまたは  が null です。 </exception>
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TThird, TFourth, TFifth, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            IEnumerable<TFourth> fourth,
            IEnumerable<TFifth> fifth,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TResult> resultSelector)
        {
            if (first == null)  throw Error.ArgumentNull(nameof(first));
            if (second == null)  throw Error.ArgumentNull(nameof(second));
            if (third == null)  throw Error.ArgumentNull(nameof(third));
            if (fourth == null)  throw Error.ArgumentNull(nameof(fourth));
            if (fifth == null)  throw Error.ArgumentNull(nameof(fifth));
            if (resultSelector == null)  throw Error.ArgumentNull(nameof(resultSelector));
            return ZipIterator(first, second, third, fourth, fifth, resultSelector);
        }

        private static IEnumerable<TResult> ZipIterator<TFirst, TSecond, TThird, TFourth, TFifth, TResult>(
            this IEnumerable<TFirst> first,
            IEnumerable<TSecond> second,
            IEnumerable<TThird> third,
            IEnumerable<TFourth> fourth,
            IEnumerable<TFifth> fifth,
            Func<TFirst, TSecond, TThird, TFourth, TFifth, TResult> resultSelector)
        {
            using (IEnumerator<TFirst> e1 = first.GetEnumerator())
            using (IEnumerator<TSecond> e2 = second.GetEnumerator())
            using (IEnumerator<TThird> e3 = third.GetEnumerator())
            using (IEnumerator<TFourth> e4 = fourth.GetEnumerator())
            using (IEnumerator<TFifth> e5 = fifth.GetEnumerator())
                while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext())
                    yield return resultSelector(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current);
        }
		}
}