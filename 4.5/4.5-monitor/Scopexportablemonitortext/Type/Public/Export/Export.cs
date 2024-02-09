using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortext
    {
        public static Scopexportablemonitortext Export()
        {
            Scopexportablemonitortext ScopexportablemonitortextResult = default;

            Scopexportablemonitortext Scopexportablemonitortext;

            Scopexportablemonitortext = new Scopexportablemonitortext();

            Scopexportablemonitortext.IdleObject = Idle;

            Scopexportablemonitortext.CharacterArrayObject = CharacterArray;

            Scopexportablemonitortext.ErrorObject = Error;

            Scopexportablemonitortext.CharacterObject = Character;

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
