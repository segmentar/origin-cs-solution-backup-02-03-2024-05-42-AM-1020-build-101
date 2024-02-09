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
        public static IList<FileInfo> ScopexportableioFileSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            ICollection<FileInfo> collectionResult = default;

            collectionResult = new Collection<FileInfo>();

            var deflect = new IEnumerable[2];

            deflect[0] = ScopexportableioFolderSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            foreach (DirectoryInfo directoryInfo in deflect[0])
            {
                deflect[1] = Directory.GetFiles(directoryInfo.FullName);

                foreach (String stringValue in deflect[1])
                {
                    FileInfo fileInfo;

                    fileInfo = new FileInfo(stringValue);

                    collectionResult.Add(fileInfo);

                    continue;
                }

                continue;
            }

            return new List<FileInfo>(collectionResult);
        }
    }
}
