using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo[] ScopexportableioFileExtensionSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should, String Extension_VALUE)
        {
            FileInfo[] arrayResult = default;

            var list = ScopexportableioFileExtensionSet(DirectoryFullName___VALUE, answer_SELF_should, Extension_VALUE);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
