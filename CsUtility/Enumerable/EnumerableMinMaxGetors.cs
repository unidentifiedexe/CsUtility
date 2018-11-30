

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CsUtility.Enumerable
{

    public static partial class EnumerableUtilities
    {
    
        #region MinItem
        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            sbyte value = default(sbyte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            sbyte? value = default(sbyte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            byte value = default(byte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            byte? value = default(byte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            char value = default(char);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            char? value = default(char?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            short value = default(short);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            short? value = default(short?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ushort value = default(ushort);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ushort? value = default(ushort?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            int value = default(int);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            int? value = default(int?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            uint value = default(uint);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            uint? value = default(uint?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            long value = default(long);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            long? value = default(long?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ulong value = default(ulong);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ulong? value = default(ulong?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            float value = default(float);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float x = keySelector(item);
                    					                    if (x < value  || float.IsNaN(x))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            float? value = default(float?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value  || float.IsNaN(x.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            double value = default(double);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double x = keySelector(item);
                    					                    if (x < value  || double.IsNaN(x))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            double? value = default(double?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value  || double.IsNaN(x.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            decimal value = default(decimal);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal x = keySelector(item);
                    					                    if (x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MinItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            decimal? value = default(decimal?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x < value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        #endregion

        #region MaxItem
        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            sbyte value = default(sbyte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            sbyte? value = default(sbyte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    sbyte? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            byte value = default(byte);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            byte? value = default(byte?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    byte? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            char value = default(char);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            char? value = default(char?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    char? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            short value = default(short);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            short? value = default(short?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    short? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ushort value = default(ushort);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ushort? value = default(ushort?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ushort? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            int value = default(int);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            int? value = default(int?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    int? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            uint value = default(uint);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            uint? value = default(uint?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    uint? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            long value = default(long);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            long? value = default(long?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    long? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ulong value = default(ulong);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            ulong? value = default(ulong?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    ulong? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            float value = default(float);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float x = keySelector(item);
                    					                    if (x > value  || float.IsNaN(value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            float? value = default(float?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    float? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value  || float.IsNaN(value.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            double value = default(double);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double x = keySelector(item);
                    					                    if (x > value  || double.IsNaN(value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            double? value = default(double?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    double? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value  || double.IsNaN(value.Value))
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            decimal value = default(decimal);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal x = keySelector(item);
                    					                    if (x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        public static TSource MaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> keySelector)
        {
            if (source == null) throw new ArgumentNullException("source");
            decimal? value = default(decimal?);
            bool hasValue = false;
            TSource obj = default(TSource);
            foreach (TSource item in source)
            {
                if (hasValue)
                {
                    decimal? x = keySelector(item);
                     if( x == null) continue; 					                    if (value == null || x > value )
                    {
                        value = x;
                        obj = item;
                    }
                }
                else
                {
                    value = keySelector(item);
                    hasValue = true;
                    obj = item;
                }
            }
            if (hasValue) return obj;
            throw new ArgumentException("No element");
        }

        #endregion

        #region MinMax
        public static MinMaxTuple<sbyte> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<sbyte?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<byte> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<byte?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<char> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<char?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<short> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<short?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<ushort> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<ushort?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<int> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<int?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<uint> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<uint?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<long> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<long?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<ulong> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<ulong?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<float> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<float?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<double> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<double?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<decimal> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }

        public static MinMaxTuple<decimal?> MinMax<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector) 
        {
            return MinMax(Enumerable.Select(source, selector));
        }



        public static MinMaxTuple<sbyte> MinMax(this IEnumerable<sbyte> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<sbyte>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<sbyte?> MinMax(this IEnumerable<sbyte?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<sbyte?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<byte> MinMax(this IEnumerable<byte> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<byte>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<byte?> MinMax(this IEnumerable<byte?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<byte?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<char> MinMax(this IEnumerable<char> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<char>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<char?> MinMax(this IEnumerable<char?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<char?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<short> MinMax(this IEnumerable<short> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<short>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<short?> MinMax(this IEnumerable<short?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<short?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<ushort> MinMax(this IEnumerable<ushort> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<ushort>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<ushort?> MinMax(this IEnumerable<ushort?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<ushort?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<int> MinMax(this IEnumerable<int> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<int>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<int?> MinMax(this IEnumerable<int?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<int?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<uint> MinMax(this IEnumerable<uint> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<uint>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<uint?> MinMax(this IEnumerable<uint?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<uint?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<long> MinMax(this IEnumerable<long> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<long>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<long?> MinMax(this IEnumerable<long?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<long?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<ulong> MinMax(this IEnumerable<ulong> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<ulong>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<ulong?> MinMax(this IEnumerable<ulong?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<ulong?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<float> MinMax(this IEnumerable<float> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<float>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<float?> MinMax(this IEnumerable<float?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<float?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<double> MinMax(this IEnumerable<double> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<double>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<double?> MinMax(this IEnumerable<double?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<double?>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<decimal> MinMax(this IEnumerable<decimal> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<decimal>(min, max);
            throw new ArgumentException("No element");
        }
        public static MinMaxTuple<decimal?> MinMax(this IEnumerable<decimal?> source) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<decimal?>(min, max);
            throw new ArgumentException("No element");
        }
        public struct MinMaxTuple<T>
        {
            public T Min { get; }
            public T Max { get; }

            internal MinMaxTuple(T min, T max )
            {
                Min = min;
                Max = max;
            }

            public void Deconstruct(out T min, out T max) => (min, max) = (Min, Max);

        }
        
        #endregion

        #region MinMaxItem

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, sbyte?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, byte?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, char?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, short?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ushort?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, uint?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, ulong?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        public static MinMaxTuple<TSource> MinMaxItem<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector) 
        {
            if (source == null) throw new ArgumentNullException("source");
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
            if (hasValue) return new MinMaxTuple<TSource>(minItem, maxItem);
            throw new ArgumentException("No element");
        }

        #endregion
    }
}