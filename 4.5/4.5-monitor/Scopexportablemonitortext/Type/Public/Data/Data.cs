using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortext
    {
        public static Scopexportablemonitortext Data()
        {
            Scopexportablemonitortext ScopexportablemonitortextResult = default;

            Scopexportablemonitortext Scopexportablemonitortext;

            Scopexportablemonitortext = new Scopexportablemonitortext();

            Scopexportablemonitortext.IdleObject = true;

            Scopexportablemonitortext.CharacterArrayObject = Scopexportablecharacterarraysafe.ForgeDefault(new Char[0]);

            Scopexportablemonitortext.ErrorObject = -1;

            Scopexportablemonitortext.CharacterObject = Scopexportablecharactersafe.ForgeDefault((Char)Scopexportableascii.EntityNull);

            Scopexportablemonitortext.StartOfLineObject = StartOfLine;

            Scopexportablemonitortext.EndOfLineObject = EndOfLine;

            Scopexportablemonitortext.VirtualOffsetObject = VirtualOffset;

            Scopexportablemonitortext.LineNumberObject = LineNumber;

            Scopexportablemonitortext.LineObject = Line;

            ScopexportablemonitortextResult = Scopexportablemonitortext;

            return ScopexportablemonitortextResult; 
        }
    }
}
