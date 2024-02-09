using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablehierarchynumeratesolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablehierarchynumeratesolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ObjectValue) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PositionLeft) + ':' + ' ' + PositionLeft,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(PositionRight) + ':' + ' ' + PositionRight,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(CharacterLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(CharacterLeft) + ':' + ' ' + CharacterLeft.ValueSafe,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(CharacterRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(CharacterRight) + ':' + ' ' + CharacterRight.ValueSafe,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(Value) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(Value) + ':' + ' ' + Value.ValueSafe,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(ObjectArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectArray.Length}>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Real) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(Real) + ':' + ' ' + Real.ValueSafe,
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(Identity) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(Identity) + ':' + ' ' + Identity.ValueSafe,
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(Link) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(Link) + ':' + ' ' + Link.ValueSafe,
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(RequireShould) + ':' + ' ' + RequireShould,
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(OptionShould) + ':' + ' ' + OptionShould,
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(AnyShould) + ':' + ' ' + AnyShould,
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(SomeShould) + ':' + ' ' + SomeShould,
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(DivideShould) + ':' + ' ' + DivideShould,
                String.Empty + '\t' + '~' + "22" + ' ' + nameof(SequenceShould) + ':' + ' ' + SequenceShould,
                String.Empty + '\t' + '~' + "23" + ' ' + nameof(SentenceShould) + ':' + ' ' + SentenceShould,
                String.Empty + '\t' + "~" + "24" + ' ' + nameof(ParagraphShould) + ':' + ' ' + ParagraphShould,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectValue) + ':',
                String.Empty + ObjectValue,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ObjectArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectArray)
            });
        }
    }
}
