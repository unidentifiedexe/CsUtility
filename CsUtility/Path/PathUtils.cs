using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsUtility.Path
{

    /// <summary> パスの変換をサポートするクラス </summary>
    static public class PathChnager
    {
        /// <summary> 拡張子をそのままにファイル名を変換します </summary>
        /// <param name="path"> 変換元のファイルパス </param>
        /// <param name="newName"> 変換後のファイル名 </param>
        /// <returns></returns>
        static public string ChangeFileName(string path, string newName)
        {
            var dir = System.IO.Path.GetDirectoryName(path);
            var extention = System.IO.Path.GetExtension(path);

            return System.IO.Path.Combine(dir, $"{newName}{extention}");
        }


        /// <summary> 拡張子をそのままにファイル名に名前を追加しますを変換します </summary>
        /// <param name="path"> 変換元のファイルパス </param>
        /// <param name="addName"> 追加する名前 </param>
        /// <returns></returns>
        static public string AddFileName(string path, string addName)
        {
            var dir = System.IO.Path.GetDirectoryName(path);
            var file = System.IO.Path.GetFileNameWithoutExtension(path);
            var extention = System.IO.Path.GetExtension(path);

            return System.IO.Path.Combine(dir, $"{file}{addName}{extention}");
        }


        /// <summary> 拡張子をそのままにファイル名を変換します </summary>
        /// <param name="path"> 変換元のファイルパス </param>
        /// <param name="nameChanger"> 旧ファイル名から新ファイル名に変換する関数 </param>
        /// <returns></returns>
        static public string ChangeFileName(string path, Func<string, string> nameChanger)
        {
            var dir = System.IO.Path.GetDirectoryName(path);
            var newName = nameChanger(System.IO.Path.GetFileNameWithoutExtension(path));
            var extention = System.IO.Path.GetExtension(path);

            return System.IO.Path.Combine(dir, $"{newName}{extention}");

        }
    }
}
