using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial class XSingle
        {
            public ScopexportablelevelHierarchyX_pqrstY[] LevelArray;

            public XSingle(ScopexportablelevelHierarchyX_pqrstY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XSingle()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ScopexportablelevelHierarchyX_pqrstY) + ' ' + "::" + ' ' + '{',
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
