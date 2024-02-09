using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class Scopexportableformat
    {
        public static String GroupRoute(String value_STRING)
        {
            String stringResult = default;

            var EntryAssemblyFileFilename____VALUE = Assembly.GetEntryAssembly().Location;

            var path = String.Empty;

            path = Path.Combine(EntryAssemblyFileFilename____VALUE);

            path = Path.GetDirectoryName(path);

            var split = value_STRING.Split(ScopexportableradicalFormat.FormatCharacterArray, StringSplitOptions.RemoveEmptyEntries);

            foreach (String stringValue in split)
            {
                path = Path.Combine(path, stringValue);

                continue;
            }

            var path_DIRECTORY_full_name = path;

            var result = path_DIRECTORY_full_name;

            stringResult = result;

            return stringResult;
        }
    }
}
