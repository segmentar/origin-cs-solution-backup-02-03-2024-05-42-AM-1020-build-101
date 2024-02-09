using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial class XDecuple
        {
            public Scopexportablehierarchysolid[] ScopexportablehierarchysolidArray;

            public XDecuple(Scopexportablehierarchysolid[] scopexportablehierarchysolidArray)
            {
                this.ScopexportablehierarchysolidArray = scopexportablehierarchysolidArray;

                return;
            }

            ~XDecuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
             
                    String.Empty + nameof(XDecuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportablehierarchysolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportablehierarchysolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportablehierarchysolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportablehierarchysolidArray)
                });
            }
        }
    }
}
