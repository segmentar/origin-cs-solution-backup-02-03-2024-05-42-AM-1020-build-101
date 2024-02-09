using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XDouble
        {
            public ScopexportablelevelBodyXo_qrstY[] LevelArray;

            public XDouble(ScopexportablelevelBodyXo_qrstY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Scopexportableism]

            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "level",
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
