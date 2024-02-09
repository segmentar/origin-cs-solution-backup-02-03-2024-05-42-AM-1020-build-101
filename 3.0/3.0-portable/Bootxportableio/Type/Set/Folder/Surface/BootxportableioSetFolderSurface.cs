using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableio
    {
        public static DirectoryInfo[] BootxportableioFolderSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = BootxportableioFolderSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, BootxportablePolicy.BootxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
