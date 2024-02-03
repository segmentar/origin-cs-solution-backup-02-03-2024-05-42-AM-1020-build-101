using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        [Expressionxportableisc]
        public partial class XDouble
        {
            public ExpressionxportablereadXo_qrstY[] LevelArray;

            public XDouble(ExpressionxportablereadXo_qrstY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
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
