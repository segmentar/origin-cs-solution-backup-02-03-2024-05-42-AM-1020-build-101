using Core;

namespace Core
{
    using System;

    public partial class Scopexportable
    {
        static Scopexportable()
        {
            return;
        }

        public static void Procedure()
        {
            ScopexportablePolicy.ScopexportableDebugPolicy = true;

            ScopexportablePolicy.ScopexportableInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            Scopexportablefolder.Folder(true);

            Scopexportableconfigure.Import(Scopexportableconfigure.Data());

            return;
        }

        public static void Raise()
        {
            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
