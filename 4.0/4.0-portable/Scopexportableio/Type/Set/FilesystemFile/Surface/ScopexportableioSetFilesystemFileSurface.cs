using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableio
    {
        public static FileInfo[] ScopexportableioFilesystemFileSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = ScopexportableioFilesystemFileSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
