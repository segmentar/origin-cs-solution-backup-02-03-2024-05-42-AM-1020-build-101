using Core;

namespace Core
{
    using System;

    public partial class Scopexportableio
    {
        public static String[] ScopexportableioFilesystemExtensionSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should, String Extension_VALUE)
        {
            String[] arrayResult = default;

            var list = ScopexportableioFilesystemSet(DirectoryFullName___VALUE, answer_SELF_should, Extension_VALUE);

            var array = new String[list.Count];

            list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
