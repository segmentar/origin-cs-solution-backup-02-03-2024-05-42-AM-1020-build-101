using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class Scopexportablefolder
    {
        public static DirectoryInfo Folder(Boolean answer_CREATE_should)
        {
            DirectoryInfo directoryInfoResult = default;

            var EntryAssemblyFileFilename____VALUE = Assembly.GetEntryAssembly().Location;

            var path = String.Empty;

            path = Path.Combine(path, EntryAssemblyFileFilename____VALUE);

            path = Path.GetDirectoryName(path);

            path = Path.Combine(path, Scopexportablestoreextension.EntityFolderName);

            var path_DIRECTORY_full_name = path;

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean isEqualContagentCheck;

            isEqualContagentCheck = boolean is true;

            DirectoryInfo directoryInfo;

            if (isEqualContagentCheck is true)
            {
                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);
            }
            else
            {
                directoryInfo = new DirectoryInfo(path_DIRECTORY_full_name);
            }

            directoryInfoResult = directoryInfo;

            return directoryInfoResult;
        }
    }
}
