using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scopexportablerender
    {
        public static void GroupRender(String Route_VALUE, params Object[] array_OBJECT)
        {
            var path_DIRECTORY_full_name = Scopexportableformat.GroupRoute(Route_VALUE);

            Scopexportableio.GroupCreateFolder(path_DIRECTORY_full_name, true);

            var ordinal = 1;

            foreach (Object value_OBJECT in array_OBJECT)
            {
                var name = Path.GetRandomFileName();

                var path_FILE_filename_with_extension = Scopexportableformat.GroupPath(path_DIRECTORY_full_name, ordinal, name);

                Scopexportableio.GroupCreateFile(path_FILE_filename_with_extension, true, value_OBJECT.ToString());

                ordinal = ordinal + 1;

                continue;
            }

            return;
        }
    }
}
