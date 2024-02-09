using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial struct XDouble
        {
            public Int32 Position;

            public Scopexportablecharactersafe Character;

            public Boolean Opposite;

            public Scopexportablecharactersafe CharacterOpposite;

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Position) + ':' + ' ' + Position,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Character) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(Character) + ':' + ' ' + Character.ValueSafe,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(Opposite) + ':' + ' ' + Opposite,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(CharacterOpposite) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(CharacterOpposite) + ':' + ' ' + CharacterOpposite.ValueSafe,
                    String.Empty + '}'
                });
            }
        }
    }
}
