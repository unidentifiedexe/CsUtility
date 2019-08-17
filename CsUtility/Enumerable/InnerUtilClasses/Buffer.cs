using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Enumerable.InnerUtils
{
    internal struct Buffer<TElement>
    {
        internal TElement[] _items;
        internal int _count;

        internal Buffer(IEnumerable<TElement> source)
        {
            TElement[] items = null;
            int count = 0;
            if (source is ICollection<TElement> collection)
            {
                count = collection.Count;
                if (count > 0)
                {
                    items = new TElement[count];
                    collection.CopyTo(items, 0);
                }
            }
            else
            {
                foreach (TElement item in source)
                {
                    if (items == null)
                    {
                        items = new TElement[4];
                    }
                    else if (items.Length == count)
                    {
                        TElement[] newItems = new TElement[checked(count * 2)];
                        Array.Copy(items, 0, newItems, 0, count);
                        items = newItems;
                    }
                    items[count] = item;
                    count++;
                }
            }
            _items = items;
            _count = count;
        }

        internal void Add(TElement element)
        {
            var items = _items;
            var count = _count;
            {
                var item = element;
                {
                    if (items == null)
                    {
                        items = new TElement[4];
                    }
                    else if (items.Length == count)
                    {
                        TElement[] newItems = new TElement[checked(count * 2)];
                        Array.Copy(items, 0, newItems, 0, count);
                        items = newItems;
                    }
                    items[count] = item;
                    count++;
                }
            }
            _items = items;
            _count = count;
        }

        internal void Clear()
        {
            _items = null;
            _count = 0;
        }

        internal TElement[] ToArray()
        {
            if (_count == 0) return new TElement[0];
            if (_items.Length == _count) return _items;
            TElement[] result = new TElement[_count];
            Array.Copy(_items, 0, result, 0, _count);
            return result;
        }
    }
}
