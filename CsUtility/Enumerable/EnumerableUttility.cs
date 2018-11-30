using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CsUtility.EnumerableUtillity
{

    public static partial class EnumerableUtility
    {
        //public static TSource MinItem<TSource, T>(this IEnumerable<TSource> source, Func<TSource, T> keySelector) where T : IComparable<T>
        //{
        //    if (source == null) throw new ArgumentNullException("source");
        //    T value = default(T);
        //    bool hasValue = false;
        //    TSource obj = default(TSource);
        //    foreach (TSource item in source)
        //    {
        //        if (hasValue)
        //        {
        //            T x = keySelector(item);
        //            if (x?.CompareTo(value) == 1)
        //            {
        //                value = x;
        //                obj = item;
        //            }
        //        }
        //        else
        //        {
        //            value = keySelector(item);
        //            hasValue = true;
        //            obj = item;
        //        }
        //    }
        //    if (hasValue) return obj;
        //    throw new ArgumentException("No element");
        //}

        //public static TSource MaxItem<TSource, T>(this IEnumerable<TSource> source, Func<TSource, T> keySelector) where T : IComparable<T>
        //{
        //    if (source == null) throw new ArgumentNullException("source");
        //    T value = default(T);
        //    bool hasValue = false;
        //    TSource obj = default(TSource);
        //    foreach (TSource item in source)
        //    {
        //        if (hasValue)
        //        {
        //            T x = keySelector(item);
        //            if ((x?.CompareTo(value)) == -1)
        //            {
        //                value = x;
        //                obj = item;
        //            }
        //        }
        //        else
        //        {
        //            value = keySelector(item);
        //            hasValue = true;
        //            obj = item;
        //        }
        //    }
        //    if (hasValue) return obj;
        //    throw new ArgumentException("No element");
        //}
        
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


    }
}
