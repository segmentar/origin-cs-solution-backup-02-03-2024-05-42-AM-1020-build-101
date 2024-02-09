using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using System.Reflection;

    public partial struct Scopexportablevalidfile
    {
        public static IList<Scopexportablevalidfile> ScopexportablevalidfileSetDefault(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID)
        {
            ICollection<Scopexportablevalidfile> collectionResult = default;

            collectionResult = new Collection<Scopexportablevalidfile>();

            var EntryAssemblyFileFilename____VALUE = Assembly.GetEntryAssembly().Location;

            var DirectoryFullName_PATH = Path.GetDirectoryName(EntryAssemblyFileFilename____VALUE);

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEACCUMULATESOLID in array_SCOPEXPORTABLEACCUMULATESOLID)
            {
                var array = Scopexportableio.ScopexportableioFilesystemFileExtensionSetSurface(DirectoryFullName_PATH, true, value_SCOPEXPORTABLEACCUMULATESOLID.Scopexportableheadersolid.Extension.Value);

                foreach (FileInfo fileInfo in array)
                {
                    Scopexportablevalidfile scopexportablevalidfile;

                    scopexportablevalidfile = new Scopexportablevalidfile();

                    scopexportablevalidfile.FileInfo = fileInfo;

                    scopexportablevalidfile.Scopexportableaccumulatesolid = value_SCOPEXPORTABLEACCUMULATESOLID;

                    collectionResult.Add(scopexportablevalidfile);

                    continue;
                }

                continue;
            }

            return new List<Scopexportablevalidfile>(collectionResult);
        }
    }
}
