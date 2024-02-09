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
        public static IList<DirectoryInfo> ScopexportableioFolderSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            ICollection<DirectoryInfo> collectionResult = default;

            collectionResult = new Collection<DirectoryInfo>();

            if (answer_SELF_should is true)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = new DirectoryInfo(DirectoryFullName___VALUE);

                collectionResult.Add(directoryInfo);
            }
            else
                "false".ToString();

            foreach (String stringValue in Directory.GetDirectories(DirectoryFullName___VALUE))
            {
                var array = ScopexportableioFolderSetSurface(stringValue, answer_SELF_should);

                foreach (DirectoryInfo directoryInfo in array)
                {
                    collectionResult.Add(directoryInfo);

                    continue;
                }

                continue;
            }

            return new List<DirectoryInfo>(collectionResult);
        }
    }
}
