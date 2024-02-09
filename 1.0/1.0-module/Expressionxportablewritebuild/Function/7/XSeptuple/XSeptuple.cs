using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablewritebuildModule
    {
        [Expressionxportableisc]
        public partial class XSeptuple
        {
            public ExpressionxportablewriteU_pqrstV[] LevelArray;

            public XSeptuple(ExpressionxportablewriteU_pqrstV[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XSeptuple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XSeptuple) + ' ' + "::" + ' ' + '{',
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
