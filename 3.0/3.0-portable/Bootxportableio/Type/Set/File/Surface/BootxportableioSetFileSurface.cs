using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static FileInfo[] BootxportableioFileSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = BootxportableioFileSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
