using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XNonuple
        {
            public Scopexportableformbodysolid[] ScopexportablebodysolidArray;

            public XNonuple(Scopexportableformbodysolid[] scopexportablebodysolidArray)
            {
                this.ScopexportablebodysolidArray = scopexportablebodysolidArray;

                return;
            }

            ~XNonuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XNonuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportablebodysolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportablebodysolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportablebodysolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportablebodysolidArray)
                });
            }
        }
    }
}
