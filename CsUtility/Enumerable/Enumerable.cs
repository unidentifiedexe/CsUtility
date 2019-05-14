using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;


namespace CsUtility.Enumerable
{
    /// <summary>
    /// <see cref="System.Linq.Enumerable"/> および <see cref="IEnumerable"/> の Utility コードを定義しているクラス。
    /// </summary>
    public static partial class EnumerableUtilities
    {

        /// <summary>
        /// 条件を満たす最初の要素を返します。存在しない場合は場合は与えられた初期値を返します。
        /// </summary>
        /// <typeparam name="TSource">要素の型</typeparam>
        /// <param name="source">探索する対象</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <param name="defaultValue">初期値</param>
        /// <exception cref="ArgumentNullException"> 
        /// <paramref name="source"/> または <paramref name="predicate"/> が null です。
        /// </exception>
        /// <returns> 条件を満たす最初の要素。条件を満たす要素が無い場合は <paramref name="defaultValue"/> </returns>
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, TSource defaultValue)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            foreach (TSource element in source)
            {
                if (predicate(element)) return element;
            }
            return defaultValue;
        }

        /// <summary>
        /// 条件を満たす最後の要素を返します。存在しない場合は場合は与えられた初期値を返します。
        /// </summary>
        /// <typeparam name="TSource"> 要素の型</typeparam>
        /// <param name="source"> 探索する対象</param>
        /// <param name="predicate"> 各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <param name="defaultValue"> 初期値。</param>
        /// <exception cref="ArgumentNullException"> 
        /// <paramref name="source"/> または <paramref name="predicate"/> が null です。
        /// </exception>
        /// <returns> 条件を満たす最後の要素。条件を満たす要素が無い場合は <paramref name="defaultValue"/> </returns>
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, TSource defaultValue)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (predicate == null) throw Error.ArgumentNull("predicate");
            TSource result = defaultValue;
            foreach (TSource element in source)
            {
                if (predicate(element))
                {
                    result = element;
                }
            }
            return result;
        }

        /// <summary>
        /// 繰り返される 1 つのジェネレータにより生成されるシーケンスを生成します。
        /// </summary>
        /// <typeparam name="TResult"> 結果のシーケンスで繰り返される値の型。</typeparam>
        /// <param name="generator"> シーケンスのジェネレータ。</param>
        /// <param name="count"> シーケンスで生成を繰り返す回数。</param>
        /// <returns> ジェネレータにより生成される要素を持つシーケンス </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="generator"/> が null です。</exception>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="count"/> が 0 未満です。</exception>
        public static IEnumerable<TResult> Repeat<TResult>(Func<TResult> generator, int count)
        {
            if (generator == null) throw Error.ArgumentNull(nameof(generator));
            if (count < 0) throw Error.ArgumentOutOfRange("count");

            IEnumerable<TResult> repeatIterator()
            {
                for (int i = 0; i < count; i++) yield return generator();
            }

            return repeatIterator();
        }

        /// <summary>
        /// 前後の要素をひとまとめにした構造体のシーケンスを生成します。
        /// </summary>
        /// <typeparam name="TSource"> 要素の型。</typeparam>
        /// <param name="source"> ひとまとめにするシーケンス。</param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception>
        /// <returns> 前後の要素をひとまとめにした構造体のシーケンス。 </returns>
        public static IEnumerable<PrevNextPair<TSource>> ZipVicinity<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            PrevNextPair<TSource> resultSelector(TSource p, TSource n) => new PrevNextPair<TSource>(p, n);
            return VicinityZipIterator(source, resultSelector);
        }

        /// <summary>
        /// 前後の要素を元に射影を行います。
        /// </summary>
        /// <typeparam name="TSource"> 要素の型。</typeparam>
        /// <typeparam name="TResult"> 返されるシーケンスの要素の型。</typeparam>
        /// <param name="source"> ひとまとめにするシーケンス。</param>
        /// <param name="resultSelector"> 各要素組に適用する変換関数。</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="resultSelector"/> が null です。
        /// </exception>
        /// <returns> 射影されたシーケンス。 </returns>
        public static IEnumerable<TResult> ZipVicinity<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (resultSelector == null) throw Error.ArgumentNull(nameof(resultSelector));
            return VicinityZipIterator(source, resultSelector);
        }
        
        private static IEnumerable<TResult> VicinityZipIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
        {
            bool hasValue = false;
            TSource prevValue = default(TSource);
            foreach (var item in source)
            {
                if (hasValue)
                {
                    yield return resultSelector(prevValue, item);
                    prevValue = item;
                }
                else
                {
                    prevValue = item;
                    hasValue = true;
                }
            }
        }

        /// <summary>
        /// 指定数毎に切り分けられたシーケンスを返します。
        /// </summary>
        /// <typeparam name="TSource"> シーケンスの要素の型。 </typeparam>
        /// <param name="source"> 切り分けれられるシーケンス。 </param>
        /// <param name="number"> 切り分けるシーケンスの数。 </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="number"/> が 1 未満です。 </exception>
        /// <returns> 切り分けられたシーケンス。</returns>
        public static IEnumerable<IEnumerable<TSource>> Split<TSource>(this IEnumerable<TSource> source, int number)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (number < 1) throw Error.ArgumentOutOfRange(nameof(number));
            else if (number == 1) return source.Select(p => new[] { p });
            else return SplitIteretor(source, number);
        }

        private static IEnumerable<IEnumerable<TSource>> SplitIteretor<TSource>(IEnumerable<TSource> source, int number)
        {

            var retArray = new TSource[number];
            int count = 0;

            foreach (var item in source)
            {
                retArray[count] = item;
                count++;
                if (count == number)
                {
                    yield return retArray;
                    retArray = new TSource[number];
                    count = 0;
                }
            }
            if (count != 0)
            {
                var ret = new TSource[count];
                Array.Copy(retArray, 0, ret, 0, count);
                yield return ret;
            }
        }

        /// <summary>
            /// 指定条件の要素の間で切り分けられたシーケンスを返します。
            /// </summary>
            /// <typeparam name="TSource"> シーケンスの要素の型。 </typeparam>
            /// <param name="source"> 切り分けれられるシーケンス。 </param>
            /// <param name="predicate"> 切り分ける条件を示す関数。 </param>
            /// <exception cref="ArgumentNullException">
            /// <paramref name="source"/> または <paramref name="predicate"/> が null です。
            /// </exception>
            /// <returns> 切り分けられたシーケンス。</returns>
        public static IEnumerable<IEnumerable<TSource>> SplitIf<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, bool> predicate)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (predicate == null) throw Error.ArgumentNull(nameof(predicate));

            return SplitIfIteretor(source, predicate);

        }


        private static IEnumerable<IEnumerable<TSource>> SplitIfIteretor<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, bool> predicate)
        {
            var tempArray = new TSource[4];
            var previous = default(TSource);
            bool hasValue = false;
            int count = 0;
            TSource[] ret;
            foreach (var item in source)
            {
                if (hasValue)
                {
                    if (predicate(previous, item))
                    {
                        ret = new TSource[count];
                        Array.Copy(tempArray, 0, ret, 0, count);
                        yield return ret;
                        count = 0;
                    }
                }
                else
                {
                    hasValue = true;
                }

                if (tempArray.Length == count)
                {
                    TSource[] newItems = new TSource[checked(count * 2)];
                    Array.Copy(tempArray, 0, newItems, 0, count);
                    tempArray = newItems;
                }
                tempArray[count] = item;
                previous = item;
                count++;
            }
            if (count != 0)
            {
                ret = new TSource[count];
                Array.Copy(tempArray, 0, ret, 0, count);
                yield return ret;
            }

        }

        /// <summary>
        /// シーケンスにアキュムレータ関数を適用しその過程を要素とするシーケンスを返します。
        /// 指定されたシード値が最初のアキュムレータ値として使用されます。
        /// </summary>
        /// <typeparam name="TSource"> 集計対象となるシーケンスの要素の型。 </typeparam>
        /// <typeparam name="TAccumulate"> アキュムレータ値の型 </typeparam>
        /// <param name="source"> 集計対象となるシーケンス </param>
        /// <param name="seed"> 最初のアキュムレータ値。 </param>
        /// <param name="func"> 各要素に対して呼び出すアキュムレータ関数。</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="func"/> が null です。
        /// </exception>
        /// <returns>アキュムレータ関数を適用の過程を要素とするシーケンス</returns>
        public static IEnumerable<TAccumulate> AggregateSelect<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (func == null) throw Error.ArgumentNull("func");
            return AggregateSelectIterator(source, seed, func);
        }

        private  static IEnumerable<TAccumulate> AggregateSelectIterator<TSource, TAccumulate>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            TAccumulate result = seed;
            foreach (TSource element in source) yield return result = func(result, element);
        }

        /// <summary>
        /// シーケンスにアキュムレータ関数を適用しその過程を要素とするシーケンスを返します。
        /// </summary>
        /// <typeparam name="TSource"> 集計対象となるシーケンスの要素の型。 </typeparam>
        /// <param name="source"> 集計対象となるシーケンス </param>
        /// <param name="func"> 各要素に対して呼び出すアキュムレータ関数。</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="func"/> が null です。
        /// </exception>
        /// <returns>アキュムレータ関数を適用の過程を要素とするシーケンス</returns>
        public static IEnumerable<TSource> AggregateSelect<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (func == null) throw Error.ArgumentNull("func");

            return AggregateSelectIterator(source, func);
        }

        private static IEnumerable<TSource> AggregateSelectIterator<TSource>(IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                TSource result;
                yield return result = e.Current;
                while (e.MoveNext()) yield return result = func(result, e.Current);
            }
        }


        //TODO:仕様決定
        /// <summary>
        /// シーケンスにアキュムレータ関数を適用しその過程の結果を射影したシーケンスを返します。
        /// </summary>
        /// <typeparam name="TSource"> 集計対象となるシーケンスの要素の型。 </typeparam>
        /// <typeparam name="TAccumulate"> アキュムレータ値の型 </typeparam>
        /// <typeparam name="TResult"> 返り値のシーケンスの型。 </typeparam>
        /// <param name="source"> 集計対象となるシーケンス </param>
        /// <param name="seed"> 最初のアキュムレータ値。 </param>
        /// <param name="func"> 各要素に対して呼び出すアキュムレータと要素の射影を行う関数。</param>
        /// <returns>アキュムレータ関数を適用の過程より射影されたシーケンス。</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="func"/> が null です。
        /// </exception>
        [Obsolete("仕様が未定です。非推奨です。")]
        public static IEnumerable<TResult> AggregateSelect<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, (TAccumulate Ag, TResult Re)> func)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (func == null) throw Error.ArgumentNull("func");
            return AggregateSelectIterator<TSource, TAccumulate, TResult>(source, seed, func);


        }

        private static IEnumerable<TResult> AggregateSelectIterator<TSource, TAccumulate, TResult>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, (TAccumulate Ag, TResult Re)> func)
        {
            TAccumulate result = seed;
            TResult ret;
            foreach (TSource element in source)
            {
                (result, ret) = func(result, element);
                yield return ret;
            }
        }


        /// <summary>
        /// シーケンスにアキュムレータ関数を適用しその過程の結果を射影したシーケンスを返します。
        /// </summary>
        /// <typeparam name="TSource"> 集計対象となるシーケンスの要素の型。 </typeparam>
        /// <typeparam name="TAccumulate"> アキュムレータ値の型 </typeparam>
        /// <typeparam name="TResult"> 返り値のシーケンスの型。 </typeparam>
        /// <param name="source"> 集計対象となるシーケンス </param>
        /// <param name="func"> 各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="seed"> 最初のアキュムレータ値。 </param>
        /// <param name="resultSelector"> アキュムレータ値と要素から結果を射影する関数。 </param>
        /// <returns>アキュムレータ関数を適用の過程から射影されたシーケンス。</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="func"/> または <paramref name="resultSelector"/> が null です。
        /// </exception>
        public static IEnumerable<TResult> AggregateSelect<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TSource, TResult> resultSelector)
        {
            if (source == null) throw Error.ArgumentNull("source");
            if (func == null) throw Error.ArgumentNull("func");
            if (resultSelector == null) throw Error.ArgumentNull(nameof(resultSelector));

            return AggregateSelectIterator<TSource, TAccumulate, TResult>(source, seed, func, resultSelector);
        }

        private static IEnumerable<TResult> AggregateSelectIterator<TSource, TAccumulate, TResult>(IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TSource, TResult> resultSelector)
        {
            TAccumulate result = seed;
            foreach (TSource element in source)
            {
                result = func(result, element);
                yield return resultSelector(result, element);
            }
        }
        

        /// <summary>
        /// 型の規定の比較子を用いてシーケンスの全ての値が等しいかどうかを取得します。
        /// </summary>
        /// <typeparam name="TSource"> source の要素の型。</typeparam>
        /// <param name="source"> 精査する対象となるシーケンス。</param>
        /// <returns> 全ての要素が等しい場合 true。そうでない場合は false </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。 </exception>s>
        static bool AllEqual<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            return AllEqualIterator(source, EqualityComparer<TSource>.Default);
        }

        /// <summary>
        /// 指定の比較子を用いてシーケンスの全ての値が等しいかどうかを取得します。
        /// </summary>
        /// <typeparam name="TSource"> source の要素の型。</typeparam>
        /// <param name="source"> 精査する対象となるシーケンス。</param>
        /// <param name="comparer"> 値を比較する <see cref="IEqualityComparer{TSource}"/>。</param>
        /// <returns> 全ての要素が等しい場合 true。そうでない場合は false </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。 </exception>
        static bool AllEqual<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            return AllEqualIterator(source, comparer ?? EqualityComparer<TSource>.Default);
        }


        /// <summary>
        /// 指定のの比較子を用いて射影されたシーケンスの全ての値が等しいかどうかを取得します。
        /// </summary>
        /// <typeparam name="TSource"> source の要素の型。</typeparam>
        /// <typeparam name="TSelect"> 比較する要素の型。</typeparam>
        /// <param name="source"> 精査する対象となるシーケンス。</param>
        /// <param name="selector"> 射影する関数。 </param>
        /// <returns> 全ての要素が等しい場合 true。そうでない場合は false </returns>
        /// <exception cref="ArgumentNullException"> 
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception>
        static bool AllEqual<TSource,TSelect>(this IEnumerable<TSource> source,Func<TSource, TSelect>selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            return AllEqualIterator(System.Linq.Enumerable.Select(source, selector), EqualityComparer<TSelect>.Default);
        }

        /// <summary>
        /// 型の規定の比較子を用いて射影されたシーケンスの全ての値が等しいかどうかを取得します。
        /// </summary>
        /// <typeparam name="TSource"> source の要素の型。</typeparam>
        /// <typeparam name="TSelect"> 比較する要素の型。</typeparam>
        /// <param name="source"> 精査する対象となるシーケンス。</param>
        /// <param name="comparer"> 値を比較する <see cref="IEqualityComparer{TSource}"/>。</param>
        /// <param name="selector"> 射影する関数。 </param>
        /// <returns> 全ての要素が等しい場合 true。そうでない場合は false </returns>
        /// <exception cref="ArgumentNullException"> 
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception>
        static bool AllEqual<TSource, TSelect>(this IEnumerable<TSource> source, Func<TSource, TSelect> selector, IEqualityComparer<TSelect> comparer)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            return AllEqualIterator(System.Linq.Enumerable.Select(source, selector), comparer ?? EqualityComparer<TSelect>.Default);
        }

        private static bool AllEqualIterator<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
        {
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw Error.NoElements();
                TSource first = e.Current;
                while (e.MoveNext())
                    if (!comparer.Equals(first, e.Current))
                        return false;

                return true;
            }

        }

        /// <summary>
        /// 2 次元のジャグシーケンスを平滑化します
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。 </typeparam>
        /// <param name="source"> 平坦化する 2 次元のジャグシーケンス。 </param>
        /// <returns> 平坦化されたシーケンス。 </returns>
        public static IEnumerable<TSource> SelectMany<TSource>(this IEnumerable<IEnumerable<TSource>> source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            return SelectManyIterator(source);
        }

        static IEnumerable<TSource> SelectManyIterator<TSource>(this IEnumerable<IEnumerable<TSource>> source)
        {
            foreach (IEnumerable<TSource> element in source)
                foreach (TSource subElement in element)
                    yield return subElement;
        }
        
        //public static IEnumerable<TResult> Zip<TSource,TResult>(this IEnumerable<IEnumerable<TSource>> source, Func<IEnumerable<TSource>, TResult> resultSelector)
        //{
        //    if (source == null) throw Error.ArgumentNull(nameof(source));
        //    if (resultSelector == null) throw Error.ArgumentNull(nameof(resultSelector));

        //    IEnumerable<TResult> iterator()
        //    {
        //        foreach (var item in source)
        //            yield return resultSelector(item);
        //    }

        //    return iterator();
        //}
    }
}
