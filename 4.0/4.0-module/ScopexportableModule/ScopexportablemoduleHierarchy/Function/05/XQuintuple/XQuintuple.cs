using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial struct XQuintuple
        {
            public Object ObjectValue;

            public Int32 PositionLeft;

            public Int32 PositionRight;

            public Scopexportablecharactersafe CharacterLeft;

            public Scopexportablecharactersafe CharacterRight;

            public Scopexportablestringsafe Value;

            public Object[] ObjectArray;

            public Object ObjectValueParent;

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XQuintuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
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
                    String.Empty + '\t' + '~' + "11" + ' ' + nameof(ObjectValueParent) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ObjectValue) + ':',
                    String.Empty + ObjectValue,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(ObjectArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ObjectArray),
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(ObjectValueParent) + ':',
                    String.Empty + ObjectValueParent
                });
            }
        }
    }
}
