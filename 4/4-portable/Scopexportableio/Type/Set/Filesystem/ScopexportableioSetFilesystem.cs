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
        public static IList<String> ScopexportableioFilesystemSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var item = ScopexportableioFolderSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            foreach (DirectoryInfo directoryInfo in item)
            {
                collectionResult.Add(directoryInfo.FullName);

                continue;
            }

            foreach (DirectoryInfo directoryInfo in item)
            {
                var entry = ScopexportableioFileSetSurface(directoryInfo.FullName, answer_SELF_should);

                foreach (FileInfo fileInfo in entry)
                {
                    collectionResult.Add(fileInfo.FullName);

                    continue;
                }
            }

            return new List<String>(collectionResult);
        }
    }
}
