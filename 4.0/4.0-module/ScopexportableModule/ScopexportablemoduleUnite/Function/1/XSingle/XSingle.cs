using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        [Scopexportableisc]
        public partial class XSingle
        {
            public Scopexportableformbuildsolid[] ScopexportableaccumulatesolidArray;

            public XSingle(Scopexportableformbuildsolid[] scopexportableaccumulatesolidArray)
            {
                this.ScopexportableaccumulatesolidArray = scopexportableaccumulatesolidArray;

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
                
                    String.Empty + nameof(XSingle) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableaccumulatesolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableaccumulatesolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableaccumulatesolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableaccumulatesolidArray)
                });
            }
        }
    }
}
