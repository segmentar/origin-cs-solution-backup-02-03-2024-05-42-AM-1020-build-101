using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XUndecuple
        {
            public Scopexportableformheadersolid[] ScopexportableheadersolidArray;

            public XUndecuple(Scopexportableformheadersolid[] scopexportableheadersolidArray)
            {
                this.ScopexportableheadersolidArray = scopexportableheadersolidArray;

                return;
            }

            ~XUndecuple()
            {
                return;
            }

            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XUndecuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableheadersolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableheadersolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableheadersolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableheadersolidArray)
                });
            }
        }
    }
}
