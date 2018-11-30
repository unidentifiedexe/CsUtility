using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace CsUtility.Enumerable
{

    public static partial class EnumerableUtilities
    {
        #region インナー構造体

        public struct PrevNextPair<T>
        {
            public T Prev { get; }
            public T Next { get; }

            internal PrevNextPair(T prev, T next)
            {
                Prev = prev;
                Next = next;
            }

            public void Deconstruct(out T prev, out T next) => (prev, next) = (Prev, Next);
            
        }


        public struct MinMaxPair<T>
        {
            public T Min { get; }
            public T Max { get; }

            internal MinMaxPair(T min, T max)
            {
                Min = min;
                Max = max;
            }

            public void Deconstruct(out T min, out T max) => (min, max) = (Min, Max);

        }

        #endregion
        

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, TSource defaultValue)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
            foreach (TSource element in source)
            {
                if (predicate(element)) return element;
            }
            return defaultValue;
        }


        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, TSource defaultValue)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");
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


        public static IEnumerable<TResult> Repeat<TResult>(Func<TResult> generator, int count)
        {
            if (generator == null) throw new ArgumentNullException(nameof(generator));
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            for (int i = 0; i < count; i++) yield return generator();
        }


        public static IEnumerable<PrevNextPair<TSource>> ZipVicinity<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            PrevNextPair<TSource> resultSelector(TSource p, TSource n) => new PrevNextPair<TSource>(p, n);
            return VicinityZipIterator(source, resultSelector);
        }


        public static IEnumerable<TResult> ZipVicinity<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TSource, TResult> resultSelector)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (resultSelector == null) throw new ArgumentNullException(nameof(resultSelector));
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


        public static IEnumerable<IEnumerable<TSource>> Split<TSource>(this IEnumerable<TSource> source, int num)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (num < 1) throw new ArgumentOutOfRangeException(nameof(num));
            if (num == 1) foreach (var item in source) yield return new[] { item };

            var retArray = new TSource[num];
            int count = 0;

            foreach (var item in source)
            {
                retArray[count] = item;
                count++;
                if (count == num)
                {
                    yield return retArray;
                    retArray = new TSource[num];
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


        public static IEnumerable<IEnumerable<TSource>> SplitIf<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));
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
            ret = new TSource[count];
            Array.Copy(tempArray, 0, ret, 0, count);
            yield return ret;

        }

        public static IEnumerable<TAccumulate> AggregateSelect<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");
            TAccumulate result = seed;
            foreach (TSource element in source) yield return result = func(result, element);
        }


        public static IEnumerable<TSource> AggregateSelect<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");

            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                if (!e.MoveNext()) throw new ArgumentException(nameof(source));
                TSource result;
                yield return result = e.Current;
                while (e.MoveNext()) yield return result = func(result, e.Current);
            }
        }

        //TODO:仕様決定
        [Obsolete("仕様が未定です。非推奨です。")]
        public static IEnumerable<TResult> AggregateSelect<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, (TAccumulate Ag, TResult Re)> func)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");

            TAccumulate result = seed;
            TResult ret;
            foreach (TSource element in source)
            {
                (result, ret) = func(result, element);
                yield return ret;
            }
        }
        
        public static IEnumerable<TResult> AggregateSelect<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func ,Func<TAccumulate,TSource,TResult> resultSelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (func == null) throw new ArgumentNullException("func");
            if (resultSelector == null) throw new ArgumentNullException(nameof(resultSelector));

            TAccumulate result = seed;
            foreach (TSource element in source)
            {
                result = func(result, element);
                yield return resultSelector(result, element);
            }
        }
        
    }

}
