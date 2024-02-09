using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortext
    {
        public static void Import(Scopexportablemonitortext value_SCOPEXPORTABLEMONITORTEXT)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORTEXT.IdleObject;

            CharacterArray = (Scopexportablecharacterarraysafe)value_SCOPEXPORTABLEMONITORTEXT.CharacterArrayObject;

            Error = (Int32)value_SCOPEXPORTABLEMONITORTEXT.ErrorObject;

            Character = (Scopexportablecharactersafe)value_SCOPEXPORTABLEMONITORTEXT.CharacterObject;

            StartOfLine = (Int32)value_SCOPEXPORTABLEMONITORTEXT.StartOfLineObject;

            EndOfLine = (Int32)value_SCOPEXPORTABLEMONITORTEXT.EndOfLineObject;

            VirtualOffset = (Int32)value_SCOPEXPORTABLEMONITORTEXT.VirtualOffsetObject;

            LineNumber = (Int32)value_SCOPEXPORTABLEMONITORTEXT.LineNumberObject;

            Line = (Scopexportablestringsafe)value_SCOPEXPORTABLEMONITORTEXT.LineObject;

            return;
        }
    }
}
