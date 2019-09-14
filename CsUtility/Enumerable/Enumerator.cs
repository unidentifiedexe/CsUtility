using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Enumerable
{
    static public class Enumerator
    {
        public static IEnumerator<T> AsDefaultValueEnumerator<T>(this IEnumerator<T> baseObj, T defaultValue)
        {
            if (baseObj == null) return null;
            else
                return new DefaultValueEnumerator<T>(baseObj, defaultValue);
        }

        public static IEnumerator<T> AsDefaultValueEnumerator<T>(this IEnumerator<T> baseObj)
        {
            return AsDefaultValueEnumerator(baseObj, default(T));
        }


        public static IEnumerator<T> GetDefaultValueEnumerator<T>(this IEnumerable<T> source, T defaultValue)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            else
                return new DefaultValueEnumerator<T>(source.GetEnumerator(), defaultValue);
        }

        public static IEnumerator<T> GetDefaultValueEnumerator<T>(this IEnumerable<T> source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            else
                return new DefaultValueEnumerator<T>(source.GetEnumerator(), default(T));
        }
    }
    

    class DefaultValueEnumerator<T> : EnumeratorWappaer<T>
    {
        private T _defaultValue = default(T);

        public override T Current => _hasValue ? _builder.Current : _defaultValue;

        public DefaultValueEnumerator(IEnumerator<T> builder , T defaultValue)
            :base(builder)
        {
            _defaultValue = defaultValue;
        }
    }

    abstract class EnumeratorWappaer<T> : IEnumerator<T>
    {
        protected readonly IEnumerator<T> _builder;
        protected bool _hasValue = false;


        public abstract T Current { get; }
        
        object IEnumerator.Current => Current;

        T IEnumerator<T>.Current => Current;

        protected EnumeratorWappaer(IEnumerator<T> builder)
        {
            _builder = builder;
        }

        public bool MoveNext()
        {
            return _hasValue = _builder.MoveNext();
        }

        public void Dispose()
        {
            _builder.Dispose();
        }

        public void Reset()
        {
            _builder.Reset();
            _hasValue = false;
        }

        void IDisposable.Dispose() => Dispose();

        bool IEnumerator.MoveNext() => MoveNext();

        void IEnumerator.Reset() => Reset();
    }
}
