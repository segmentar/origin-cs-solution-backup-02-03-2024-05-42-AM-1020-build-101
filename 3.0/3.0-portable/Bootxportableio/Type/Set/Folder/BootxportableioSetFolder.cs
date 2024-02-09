using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Bootxportableio
    {
        public static IList<DirectoryInfo> BootxportableioFolderSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
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

            var deflect = new IEnumerable[2];

            deflect[0] = Directory.GetDirectories(DirectoryFullName___VALUE);

            foreach (String stringValue in deflect[0])
            {
                deflect[1] = BootxportableioFolderSetSurface(stringValue, answer_SELF_should);

                foreach (DirectoryInfo directoryInfo in deflect[1])
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
