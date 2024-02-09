using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct Scopexportablemonitorvalid
    {
        public static void CategorySync()
        {
            Error = Error + 1;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(ScopexportablevalidfileArray.Length, Error) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                Idle = true;

                return;
            }
            else
                "false".ToString();

            Scopexportablevalidfile = ScopexportablevalidfileArray[Error];

            Text = Scopexportablestringsafe.ForgeDefault(File.ReadAllText(Scopexportablevalidfile.FileInfo.FullName));

            Scopexportablemonitortext.CharacterArray = Scopexportablecharacterarraysafe.ForgeDefault(Text.Value.ToCharArray());

            Scopexportablemonitortext.Error = -1;

            Scopexportablemonitortext.Idle = false;

            return;
        }
    }
}
