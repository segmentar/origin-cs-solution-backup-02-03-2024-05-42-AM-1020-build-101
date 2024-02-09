using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scopexportableform
    {
        public static void Form(Boolean answer_PROCESS_should)
        {
            var deflect = new IEnumerable[3];

            deflect[0] = Scopexportableformscan.ForgeDefault();

            deflect[1] = Scopexportableformextract.ForgeDefault((Scopexportableformscansolid[])deflect[0]);

            deflect[2] = Scopexportableaccumulate.ForgeDefault((Scopexportableformcoordinate[])deflect[1], true, false);

            if (answer_PROCESS_should is true)
            {
                Scopexportableprocess.Process((Scopexportableformbuildsolid[])deflect[2], true);
            }
            else
                "false".ToString();

            return;
        }
    }
}
