using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortext
    {
        public static void CategorySync()
        {
            Error = Error + 1;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(CharacterArray.Value.Length, Error) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                Idle = true;

                return;
            }
            else
                "false".ToString();

            var inflect = new Object[4];

            Character = Scopexportablecharactersafe.ForgeDefault(CharacterArray.Value[Error]);

            StartOfLine = Scopexportablemonitorvalid.Text.Value.LastIndexOf(ScopexportableradicalNewLine.NewLineConcatenate, Error);

            EndOfLine = Scopexportablemonitorvalid.Text.Value.IndexOf(ScopexportableradicalNewLine.NewLineConcatenate, Error);

            VirtualOffset = (Error - StartOfLine);

            inflect[0] = (Error - 0);

            inflect[1] = Scopexportablemonitorvalid.Text.Value.Substring(0, (Int32)inflect[0]);

            var split = ((String)inflect[1]).Split(ScopexportableradicalNewLine.NewLineStringArray, StringSplitOptions.None);

            LineNumber = (split.Length - 1);

            if (Object.Equals(StartOfLine, -1) is true)
            {
                StartOfLine = 0;
            }
            else
                "false".ToString();

            if (Object.Equals(EndOfLine, -1) is true)
            {
                EndOfLine = (Scopexportablemonitorvalid.Text.Value.Length - 1);
            }
            else
                "false".ToString();

            inflect[2] = ((EndOfLine - StartOfLine) + 1);

            inflect[3] = Scopexportablemonitorvalid.Text.Value.Substring(StartOfLine, (Int32)inflect[2]);

            Line = Scopexportablestringsafe.ForgeDefault((String)inflect[3]);

            Scopexportablemonitorquery.LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportablehierarchynumeratesolid>(Scopexportablemonitorvalid.Scopexportablevalidfile.Scopexportableaccumulatesolid.ScopexportablehierarchynumeratesolidArray);

            Scopexportablemonitorquery.Error = -1;

            Scopexportablemonitorquery.Idle = false;

            return;
        }
    }
}
