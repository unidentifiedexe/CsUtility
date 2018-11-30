using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityTest.EnumerableUtillityTest
{
    partial class TestCase : IEnumerable<TestClass>
    {
        #region スタティックメンバ

        private static TestCase _nomalTestData;
        public static TestCase NomalTestCase
            => _nomalTestData = _nomalTestData ?? new TestCase(GetNomalTestData());

        private static TestCase _allNullTestCase;
        public static TestCase AllNullTestCase
            => _allNullTestCase = _allNullTestCase ?? new TestCase(GetAllNullTestData());
        


        private static IEnumerable<TestClass> GetNomalTestData()
        {
            yield return new TestClass(0, true);
            yield return new TestClass(0, true);
            yield return new TestClass(0, false);
            yield return new TestClass(1, true);
            yield return new TestClass(1, true);
            yield return new TestClass(1, false);
            yield return new TestClass(2, true);
            yield return new TestClass(2, true);
            yield return new TestClass(2, false);
        }


        private static IEnumerable<TestClass> GetAllNullTestData()
        {
            yield return new TestClass(0, false);
            yield return new TestClass(0, false);
            yield return new TestClass(0, false);
            yield return new TestClass(1, false);
            yield return new TestClass(1, false);
            yield return new TestClass(1, false);
            yield return new TestClass(2, false);
            yield return new TestClass(2, false);
            yield return new TestClass(2, false);
        }


        #endregion

        #region インスタンスメンバ

        private readonly TestClass[] _data;

        public TestCase(IEnumerable<TestClass> data)
        {
            _data = data.ToArray();
            
        }

        public TestClass[] AsArray() => _data.ToArray();
        public List<TestClass> AsList() => _data.ToList();
        public IEnumerable<TestClass> AsEnumerable()
        {
            foreach (var item in _data)
                yield return item;
        }

        public IEnumerator<TestClass> GetEnumerator()
        {
            foreach (var item in _data)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in _data)
                yield return item;
        }

        #endregion



    }
    class TestClass
    {
        private readonly bool _hasValue;
        private readonly sbyte _signedValue;
        private readonly byte _unsignedValue;
        

        public sbyte SByteValue => _signedValue;
        public sbyte? SbyteNullableValue => _hasValue ? null : (sbyte?)_signedValue;
        public byte ByteValue => _unsignedValue;
        public byte?    ByteNullableValue => _hasValue ? null : (byte?)_unsignedValue;
        public char CharValue => (char)ByteValue;
        public char? CharNullableValue => (char?)ByteNullableValue;
        public short ShortValue                => SByteValue;
        public short? ShortNullableValue       => SbyteNullableValue;
        public ushort   UshortValue            => ByteValue;
        public ushort?  UshortNullableValue    => ByteNullableValue;
        public int      IntValue               => SByteValue;
        public int?     IntNullableValue       => SbyteNullableValue;
        public uint     UintValue              => ByteValue;
        public uint?    UintNullableValue      => ByteNullableValue;
        public long     LongValue              => SByteValue;
        public long?    LongNullableValue      => SbyteNullableValue;
        public ulong    UlongValue             => ByteValue;
        public ulong?   UlongNullableValue     => ByteNullableValue;
        public float    FloatValue             => SByteValue;
        public float?   FloatNullableValue     => SbyteNullableValue;
        public double   DoubleValue            => SByteValue;
        public double?  DoubleNullableValue    => SbyteNullableValue;
        public decimal  DecimalValue           => SByteValue;
        public decimal? DecimalNullableValue   => SbyteNullableValue;


        internal TestClass(byte byteVal, bool nullHasValue) 
            : this(byteVal, (sbyte)byteVal, nullHasValue)
        {}

        internal TestClass(byte byteVal, sbyte sbyteVal, bool nullHasValue)
        {
            _unsignedValue = byteVal;
            _signedValue = sbyteVal;
            _hasValue = nullHasValue;
        }
    /**/
    }
}
