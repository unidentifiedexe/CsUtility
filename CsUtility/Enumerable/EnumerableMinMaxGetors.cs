

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CsUtility.Enumerable
{

    public static partial class EnumerableUtilities
    {
    
        #region MinItem

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            sbyte value = default(sbyte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            sbyte? value = default(sbyte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            byte value = default(byte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            byte? value = default(byte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            char value = default(char);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            char? value = default(char?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            short value = default(short);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            short? value = default(short?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ushort value = default(ushort);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ushort? value = default(ushort?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            int value = default(int);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            int? value = default(int?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            uint value = default(uint);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            uint? value = default(uint?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            long value = default(long);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            long? value = default(long?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ulong value = default(ulong);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ulong? value = default(ulong?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            float value = default(float);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float x = selector(item);
                    
                    if (x < value  || float.IsNaN(x))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            float? value = default(float?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value  || float.IsNaN(x.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            double value = default(double);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double x = selector(item);
                    
                    if (x < value  || double.IsNaN(x))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            double? value = default(double?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value  || double.IsNaN(x.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            decimal value = default(decimal);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal x = selector(item);
                    
                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最小値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            decimal? value = default(decimal?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        #endregion

        #region MaxItem

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            sbyte value = default(sbyte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            sbyte? value = default(sbyte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            byte value = default(byte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            byte? value = default(byte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            char value = default(char);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            char? value = default(char?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            short value = default(short);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            short? value = default(short?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ushort value = default(ushort);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ushort? value = default(ushort?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            int value = default(int);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            int? value = default(int?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            uint value = default(uint);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            uint? value = default(uint?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            long value = default(long);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            long? value = default(long?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ulong value = default(ulong);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            ulong? value = default(ulong?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            float value = default(float);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float x = selector(item);
                    
                    if (x > value  || float.IsNaN(value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            float? value = default(float?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value  || float.IsNaN(value.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            double value = default(double);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double x = selector(item);
                    
                    if (x > value  || double.IsNaN(value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            double? value = default(double?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value  || double.IsNaN(value.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            decimal value = default(decimal);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal x = selector(item);
                    
                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最大値を持つ要素を返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> の要素の型。</typeparam>
        /// <param name="source">最大値を確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最大値を持つ要素。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            if (selector == null) throw Error.ArgumentNull(nameof(selector));
            decimal? value = default(decimal?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal? x = selector(item);
                    if( x == null) continue; 
                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = selector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw Error.NoElements();
        }

        #endregion

        #region MinMax

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<sbyte> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<sbyte?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<byte> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<byte?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<char> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<char?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<short> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<short?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<ushort> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<ushort?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<int> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<int?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<uint> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<uint?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<long> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<long?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<ulong> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<ulong?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<float> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<float?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<double> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<double?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<decimal> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値と最大値のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<decimal?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector) 
        {
            return MinMax(System.Linq.Enumerable.Select(source, selector));
        }



        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<sbyte> MinMax(this IEnumerable<sbyte> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            sbyte min = default(sbyte);
            sbyte max = default(sbyte);
            bool hasValue = false;
            foreach (sbyte x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<sbyte>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<sbyte?> MinMax(this IEnumerable<sbyte?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            sbyte? min = default(sbyte?);
            sbyte? max = default(sbyte?);
            bool hasValue = false;
            foreach (sbyte? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<sbyte?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<byte> MinMax(this IEnumerable<byte> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            byte min = default(byte);
            byte max = default(byte);
            bool hasValue = false;
            foreach (byte x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<byte>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<byte?> MinMax(this IEnumerable<byte?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            byte? min = default(byte?);
            byte? max = default(byte?);
            bool hasValue = false;
            foreach (byte? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<byte?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<char> MinMax(this IEnumerable<char> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            char min = default(char);
            char max = default(char);
            bool hasValue = false;
            foreach (char x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<char>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<char?> MinMax(this IEnumerable<char?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            char? min = default(char?);
            char? max = default(char?);
            bool hasValue = false;
            foreach (char? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<char?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<short> MinMax(this IEnumerable<short> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            short min = default(short);
            short max = default(short);
            bool hasValue = false;
            foreach (short x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<short>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<short?> MinMax(this IEnumerable<short?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            short? min = default(short?);
            short? max = default(short?);
            bool hasValue = false;
            foreach (short? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<short?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<ushort> MinMax(this IEnumerable<ushort> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ushort min = default(ushort);
            ushort max = default(ushort);
            bool hasValue = false;
            foreach (ushort x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<ushort>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<ushort?> MinMax(this IEnumerable<ushort?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ushort? min = default(ushort?);
            ushort? max = default(ushort?);
            bool hasValue = false;
            foreach (ushort? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<ushort?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<int> MinMax(this IEnumerable<int> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            int min = default(int);
            int max = default(int);
            bool hasValue = false;
            foreach (int x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<int>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<int?> MinMax(this IEnumerable<int?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? min = default(int?);
            int? max = default(int?);
            bool hasValue = false;
            foreach (int? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<int?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<uint> MinMax(this IEnumerable<uint> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            uint min = default(uint);
            uint max = default(uint);
            bool hasValue = false;
            foreach (uint x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<uint>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<uint?> MinMax(this IEnumerable<uint?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            uint? min = default(uint?);
            uint? max = default(uint?);
            bool hasValue = false;
            foreach (uint? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<uint?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<long> MinMax(this IEnumerable<long> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            long min = default(long);
            long max = default(long);
            bool hasValue = false;
            foreach (long x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<long>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<long?> MinMax(this IEnumerable<long?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? min = default(long?);
            long? max = default(long?);
            bool hasValue = false;
            foreach (long? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<long?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<ulong> MinMax(this IEnumerable<ulong> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ulong min = default(ulong);
            ulong max = default(ulong);
            bool hasValue = false;
            foreach (ulong x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<ulong>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<ulong?> MinMax(this IEnumerable<ulong?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ulong? min = default(ulong?);
            ulong? max = default(ulong?);
            bool hasValue = false;
            foreach (ulong? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<ulong?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<float> MinMax(this IEnumerable<float> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            float min = default(float);
            float max = default(float);
            bool hasValue = false;
            foreach (float x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min  || float.IsNaN(x)) min = x;
                    if (x > max  || float.IsNaN(max)) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<float>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<float?> MinMax(this IEnumerable<float?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? min = default(float?);
            float? max = default(float?);
            bool hasValue = false;
            foreach (float? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min  || float.IsNaN(x.Value)) min = x;
                    if ( max == null || x > max  || float.IsNaN(max.Value)) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<float?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<double> MinMax(this IEnumerable<double> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            double min = default(double);
            double max = default(double);
            bool hasValue = false;
            foreach (double x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min  || double.IsNaN(x)) min = x;
                    if (x > max  || double.IsNaN(max)) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<double>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<double?> MinMax(this IEnumerable<double?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? min = default(double?);
            double? max = default(double?);
            bool hasValue = false;
            foreach (double? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min  || double.IsNaN(x.Value)) min = x;
                    if ( max == null || x > max  || double.IsNaN(max.Value)) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<double?>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<decimal> MinMax(this IEnumerable<decimal> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal min = default(decimal);
            decimal max = default(decimal);
            bool hasValue = false;
            foreach (decimal x in source) 
            {
                if (hasValue) 
                {
                     
                    if (x < min ) min = x;
                    if (x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<decimal>(min, max);
            throw Error.NoElements();
        }
        /// <summary>
        /// シーケンスの各要素の最小値と最大値のペアを返します。
        /// </summary>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <returns> 最小値と最大値のペア。 </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> が null です。</exception> 
        public static MinMaxPair<decimal?> MinMax(this IEnumerable<decimal?> source) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? min = default(decimal?);
            decimal? max = default(decimal?);
            bool hasValue = false;
            foreach (decimal? x in source) 
            {
                if (hasValue) 
                {
                    if( x == null) continue;  
                    if ( min == null || x < min ) min = x;
                    if ( max == null || x > max ) max = x;
                }
                else 
                {
                    min = x;
                    max = x;
                    hasValue = true;
                }
            }
            if (hasValue) return new MinMaxPair<decimal?>(min, max);
            throw Error.NoElements();
        }
        
        #endregion

        #region MinMaxItem

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            sbyte min = default(sbyte);
            sbyte max = default(sbyte);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            sbyte x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            sbyte? min = default(sbyte?);
            sbyte? max = default(sbyte?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            sbyte? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            byte min = default(byte);
            byte max = default(byte);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            byte x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            byte? min = default(byte?);
            byte? max = default(byte?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            byte? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            char min = default(char);
            char max = default(char);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            char x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            char? min = default(char?);
            char? max = default(char?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            char? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            short min = default(short);
            short max = default(short);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            short x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            short? min = default(short?);
            short? max = default(short?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            short? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ushort min = default(ushort);
            ushort max = default(ushort);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            ushort x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ushort? min = default(ushort?);
            ushort? max = default(ushort?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            ushort? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            int min = default(int);
            int max = default(int);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            int x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            int? min = default(int?);
            int? max = default(int?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            int? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            uint min = default(uint);
            uint max = default(uint);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            uint x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            uint? min = default(uint?);
            uint? max = default(uint?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            uint? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            long min = default(long);
            long max = default(long);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            long x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            long? min = default(long?);
            long? max = default(long?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            long? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ulong min = default(ulong);
            ulong max = default(ulong);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            ulong x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            ulong? min = default(ulong?);
            ulong? max = default(ulong?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            ulong? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            float min = default(float);
            float max = default(float);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            float x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min  || float.IsNaN(x)) {min = x; minItem = item;}
                    if (x > max  || float.IsNaN(max)) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            float? min = default(float?);
            float? max = default(float?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            float? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min  || float.IsNaN(x.Value)) {min = x; minItem = item;}
                    if ( max == null || x > max  || float.IsNaN(max.Value)) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            double min = default(double);
            double max = default(double);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            double x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min  || double.IsNaN(x)) {min = x; minItem = item;}
                    if (x > max  || double.IsNaN(max)) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            double? min = default(double?);
            double? max = default(double?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            double? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min  || double.IsNaN(x.Value)) {min = x; minItem = item;}
                    if ( max == null || x > max  || double.IsNaN(max.Value)) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal min = default(decimal);
            decimal max = default(decimal);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            decimal x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                     
                    if (x < min ) {min = x; minItem = item;}
                    if (x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        /// <summary>
        /// シーケンスの各要素に対して変換関数を呼び出し、最小値を持つ要素と最大値を持つ要素のペアを返します。
        /// </summary>
        /// <typeparam name="TSource"> <paramref name="source"/> 要素の型。</typeparam>
        /// <param name="source"> 確認する対象となるシーケンス。</param>
        /// <param name="selector"> 各要素に適用する変換関数。</param>
        /// <returns> 最小値を持つ要素と最大値を持つ要素のペア。 </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="source"/> または <paramref name="selector"/> が null です。
        /// </exception> 
        public static MinMaxPair<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector) 
        {
            if (source == null) throw Error.ArgumentNull("source");
            decimal? min = default(decimal?);
            decimal? max = default(decimal?);
            TSource minItem = default(TSource);
            TSource maxItem = default(TSource);
            bool hasValue = false;
            decimal? x;
            foreach (TSource item in source) 
            {
                x = selector(item);
                if (hasValue) 
                {
                    if( x == null)continue;  
                    if ( min == null || x < min ) {min = x; minItem = item;}
                    if ( max == null || x > max ) {max = x; maxItem = item;}
                }
                else 
                {
                    hasValue = true;
                    min = x;
                    minItem = item;
                    max = x;
                    maxItem = item;
                }
            }
            if (hasValue) return new MinMaxPair<TSource>(minItem, maxItem);
            throw Error.NoElements();
        }

        #endregion
    }
}