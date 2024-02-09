using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportableio
    {
        public static IList<FileInfo> ScopexportableioFilesystemFileExtensionSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should, String Extension_VALUE)
        {
            ICollection<FileInfo> collectionResult = default;

            collectionResult = new Collection<FileInfo>();

            var array = ScopexportableioFilesystemExtensionSetSurface(DirectoryFullName___VALUE, answer_SELF_should, Extension_VALUE);

            foreach (String stringValue in array)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = File.Exists(stringValue) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                FileInfo fileInfo;

                fileInfo = new FileInfo(stringValue);

                collectionResult.Add(fileInfo);

                continue;
            }

            return new List<FileInfo>(collectionResult);
        }
    }
}
