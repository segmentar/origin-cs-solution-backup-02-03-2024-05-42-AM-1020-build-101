using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XOctuple
        {
            public ScopexportablelevelBodyUo_qrstV[] LevelArray;

            public XOctuple(ScopexportablelevelBodyUo_qrstV[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XOctuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XOctuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':', 
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
