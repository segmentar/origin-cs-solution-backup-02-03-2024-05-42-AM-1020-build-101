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
        public static IList<String> ScopexportableioFilesystemSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should, String Extension_VALUE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var deflect = new IEnumerable[2];

            deflect[0] = ScopexportableioFolderSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            foreach (DirectoryInfo directoryInfo in deflect[0])
            {
                collectionResult.Add(directoryInfo.FullName);

                continue;
            }

            deflect[1] = ScopexportableioFileExtensionSetSurface(DirectoryFullName___VALUE, answer_SELF_should, Extension_VALUE);

            foreach (FileInfo fileInfo in deflect[1])
            {
                collectionResult.Add(fileInfo.FullName);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
