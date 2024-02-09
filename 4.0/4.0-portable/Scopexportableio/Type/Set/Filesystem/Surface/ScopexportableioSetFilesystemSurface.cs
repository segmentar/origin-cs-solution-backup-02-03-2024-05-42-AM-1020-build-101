using Core;

namespace Core
{
    using System;

    public partial class Scopexportableio
    {
        public static String[] ScopexportableioFilesystemSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            String[] arrayResult = default;

            var list = ScopexportableioFilesystemSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new String[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
