using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        [Scopexportableisc]
        public partial class XQuadruple
        {
            public Scopexportableformscansolid[] ScopexportablescansolidArray;

            public XQuadruple(Scopexportableformscansolid[] scopexportablescansolidArray)
            {
                this.ScopexportablescansolidArray = scopexportablescansolidArray;

                return;
            }

            ~XQuadruple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XQuadruple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportablescansolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportablescansolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportablescansolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportablescansolidArray)
                });
            }
        }
    }
}
