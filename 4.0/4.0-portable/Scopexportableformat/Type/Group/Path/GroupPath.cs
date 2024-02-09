using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportableformat
    {
        public static String GroupPath(String Rebase_VALUE, Int32 Ordinal_VALUE, String FileName__VALUE)
        {
            String stringResult = default;

            var format = String.Format("{0} {1}", Ordinal_VALUE, FileName__VALUE);

            var path_FILE_filename = Path.Combine(Rebase_VALUE, format);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Scopexportablestorerender.EntityExtension);

            var result = path_FILE_filename_with_extension;

            stringResult = result;

            return stringResult;
        }
    }
}
