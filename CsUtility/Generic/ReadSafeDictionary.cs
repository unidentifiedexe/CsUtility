using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Generic
{
    /// <summary>
    /// <seealso cref="ReadSafeDictionary{TKey, TValue}"/> の操作をサポートするクラス
    /// </summary>
    static class ReadSafeDictionary
    {

        /// <summary>
        /// 指定されたキーに関連付けられている値を取得します。存在しない場合は指定した初期値の要セオを作成しそれを取得します。
        /// </summary>
        /// <param name="dictionary"> 読取を試みるディクショナリ。 </param>
        /// <param name="key">取得または値のキー。</param>
        /// <param name="defaultValue"> 指定したキーが見つからなかった場合に返す値。 </param>
        /// <param name="isSetValue"> 指定したキーが見つからなかった場合に値をセットするかを指定します。 </param>
        /// <returns>
        /// 指定されたキーに関連付けられている値。 
        /// 指定したキーが見つからなかった場合初期値を返します
        /// </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> または <paramref name="dictionary"/> は null です。</exception>
        public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,TKey key, TValue defaultValue, bool isSetValue = false)
        {
            if (dictionary == null) throw new NullReferenceException(nameof(dictionary));
            {
                if (dictionary.TryGetValue(key, out var value))
                    return value;
                else
                {
                    var ret = defaultValue;
                    if (isSetValue)
                        dictionary.Add(key, ret);
                    return ret;
                }
            }
        }


        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを生成します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        public static ReadSafeDictionary<TKey, TValue> ToReadSafeDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return new ReadSafeDictionary<TKey, TValue>(dictionary, default(TValue), null);
        }

        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを生成します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public static ReadSafeDictionary<TKey, TValue> ToReadSafeDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
        {
            return new ReadSafeDictionary<TKey, TValue>(dictionary, default(TValue), comparer);
        }

        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを生成します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public static ReadSafeDictionary<TKey, TValue> ToReadSafeDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary , TValue defaultValue)
        {
            return new ReadSafeDictionary<TKey, TValue>(dictionary, defaultValue, null);
        }

        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを生成します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public static ReadSafeDictionary<TKey, TValue> ToReadSafeDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue defaultValue, IEqualityComparer<TKey> comparer)
        {
            return new ReadSafeDictionary<TKey, TValue>(dictionary,defaultValue,comparer);
        }

    }


    /// <summary>
    /// 読み取り時にインザクサで指定してもエラーを吐かない <see cref="Dictionary{TKey, TValue}"/> の派生クラス
    /// </summary>
    /// <typeparam name="TKey"> ディクショナリ内のキーの型。 </typeparam>
    /// <typeparam name="TValue"> ディクショナリ内の値の型。 </typeparam>
    [Serializable]
    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
    public class ReadSafeDictionary<TKey,TValue> : Dictionary<TKey, TValue>
    {
        private const string _defaultValueName = "DefaultValue";
        private readonly TValue _defaultValue;

        /// <summary>
        /// 空で、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// 既定の初期量を備え、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        public ReadSafeDictionary() : this(default(TValue), 0, null) { }

        /// <summary>
        /// 空で、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とする、
        /// 指定した初期量を備え、
        /// キーの型の既定の等値比較子を使用する、 
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="capacity">  が格納できる要素数の初期値。</param>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="capacity"/> が 0 未満です。</exception>
        public ReadSafeDictionary(int capacity) : this(default(TValue), capacity, null) { }

        /// <summary>
        /// 空で、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// 既定の初期量を備え、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        public ReadSafeDictionary(IEqualityComparer<TKey> comparer) : this(default(TValue), 0, comparer) { }


        /// <summary>
        /// 空で、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// 指定した初期量を備え、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <param name="capacity">  が格納できる要素数の初期値。</param>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="capacity"/> が 0 未満です。</exception>
        public ReadSafeDictionary(int capacity, IEqualityComparer<TKey> comparer) : this(default(TValue), capacity, comparer) { }


        /// <summary>
        /// 空で、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 規定の初期量を備え、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        public ReadSafeDictionary(TValue defaultValue) : this(defaultValue, 0, null) { }

        /// <summary>
        /// 空で、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 指定した初期量を備え、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <param name="capacity">  が格納できる要素数の初期値。</param>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="capacity"/> が 0 未満です。</exception>
        public ReadSafeDictionary(TValue defaultValue, int capacity) : this(defaultValue, capacity, null) { }

        /// <summary>
        /// 空で、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 規定の初期量を備え、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用し、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        public ReadSafeDictionary(TValue defaultValue, IEqualityComparer<TKey> comparer) : this(defaultValue, 0, comparer) { }

        /// <summary>
        /// 空で、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 指定した初期量を備え、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <param name="capacity">  が格納できる要素数の初期値。</param>
        /// <exception cref="ArgumentOutOfRangeException"> <paramref name="capacity"/> が 0 未満です。</exception>
        public ReadSafeDictionary(TValue defaultValue, int capacity, IEqualityComparer<TKey> comparer) : base(capacity,comparer)
        {
            _defaultValue = defaultValue;
        }

        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        public ReadSafeDictionary(IDictionary<TKey, TValue> dictionary) : this(dictionary,default(TValue), null) { }
        
        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// <typeparamref name="TKey"/> の規定値をディクショナリ内の値の規定値とし、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public ReadSafeDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : this(dictionary, default(TValue), comparer) { }


        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// キーの型の既定の等値比較子を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public ReadSafeDictionary(IDictionary<TKey, TValue> dictionary, TValue defaultValue) : this(dictionary, defaultValue, null) { }


        /// <summary>
        /// 指定した <see cref="IDictionary{TKey, TValue}"/> から要素をコピーして格納し、
        /// 指定した値をディクショナリ内の値の規定値とし、
        /// 指定した <see cref="IEqualityComparer{TKey}"/> を使用する、
        /// <see cref="ReadSafeDictionary{TKey,TValue}"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="dictionary"> 要素が新しい <see cref="ReadSafeDictionary{TKey,TValue}"/> にコピーされる  <see cref="IDictionary{TKey, TValue}"/>。</param>
        /// <param name="defaultValue"> ディクショナリ内の値の規定値。 </param>
        /// <param name="comparer">
        /// キーの比較時に使用する <see cref="IEqualityComparer{TKey}"/> 実装。
        /// キーの型の既定の <see cref="IEqualityComparer{TKey}"/> を使用する場合は null。
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dictionary"/> は null です。</exception>
        /// <exception cref="ArgumentException"> <paramref name="dictionary"/> には 1 つまたは複数の重複するキーが含まれます。</exception>
        public ReadSafeDictionary(IDictionary<TKey, TValue> dictionary, TValue defaultValue, IEqualityComparer<TKey> comparer) :
            base(dictionary, comparer)
        {
            _defaultValue = defaultValue;
        }
        
        /// <summary>
        /// 指定されたキーに関連付けられている値を取得または設定します。
        /// </summary>
        /// <param name="key">取得または設定する値のキー。</param>
        /// <returns>
        /// 指定されたキーに関連付けられている値。 
        /// 指定したキーが見つからなかった場合、
        /// get は予め指定した初期値をもつ要素を作成しそれを返します。
        /// set 操作は指定したキーを持つ新しい要素を作成します。
        /// </returns>
        /// <exception cref="ArgumentNullException"> key は null です。</exception>
        public new TValue this[TKey key]
        {
            get => GetValueOrDefault(key, _defaultValue, true);
            set => base[key] = value;
        }


        /// <summary>
        /// 指定されたキーに関連付けられている値を取得します。存在しない場合は指定した初期値の要セオを作成しそれを取得します。
        /// </summary>
        /// <param name="key">取得または値のキー。</param>
        /// <param name="defaultValue"> 指定したキーが見つからなかった場合に返す値。 </param>
        /// <param name="isSet"> 指定したキーが見つからなかった場合に値をセットするかを指定します。 </param>
        /// <returns>
        /// 指定されたキーに関連付けられている値。 
        /// 指定したキーが見つからなかった場合初期値を返します
        /// </returns>
        /// <exception cref="ArgumentNullException"> key は null です。</exception>
        public TValue GetValueOrDefault(TKey key, TValue defaultValue, bool isSet = false)
        {
            if (TryGetValue(key, out var value))
                return value;
            else
            {
                var ret = defaultValue;
                if (isSet)
                    base.Add(key, ret);
                return ret;
            }
        }

        // Implement this method to serialize data. The method is called 
        // on serialization.
        [System.Security.SecurityCritical]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            // Use the AddValue method to specify serialized values.
            info.AddValue(_defaultValueName,_defaultValue, typeof(TValue));

        }

        // The special constructor is used to deserialize values.
        protected ReadSafeDictionary(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            // Reset the property value using the GetValue method.
            _defaultValue = (TValue)info.GetValue(_defaultValueName, typeof(TValue));
        }
    }
}
