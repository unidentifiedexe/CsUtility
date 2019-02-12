using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.MultiDimensionalArray
{
    class TowDArray<T>
    {
        private readonly T[] _values;

        private readonly int[] _lengthes = new int[2];
        
        public T this[int i1,int i2]
        {
            get => _values[GetPos(i1, i2)];
            set => _values[GetPos(i1, i2)] = value;
        }

        private int GetPos(int i1, int i2)
        {
            return i1 * _lengthes[1] + i2;
        }

        private int GetInnnerLength(int dimension)
        {
            return _lengthes.Skip(dimension).Aggregate((p, n) => p * n);
        }

        public int GetLength(int i)
        {
            return _lengthes[i];
        }
    }
    
}
