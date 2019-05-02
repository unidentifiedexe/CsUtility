using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsUtility.Enumerable;

namespace UtilTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new[] { 3, 3453, 12, 534, 2, 432, 6, 234, 231 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int i = arr.Length - 1; i >=0 ; i--)
            {
                Console.WriteLine(arr[i]);
            }

            var newArr = arr.ZipVicinity((p, n) => Math.Abs(p - n)).ToArray();

            Console.WriteLine(String.Join("," ,newArr));
            Console.ReadLine();
        }
    }
}
