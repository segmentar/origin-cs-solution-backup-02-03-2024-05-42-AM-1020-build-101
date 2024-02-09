using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorparameter
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitorparameter) + ' ' + "::" + ' ' + '{',
                String.Empty + "\t" + '~' + "01" + ' ' + nameof(ScopexportableaccumulatesolidArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Scopexportableformbuildsolid[])ScopexportableaccumulatesolidArrayObject).Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ScopexportableaccumulatesolidArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Scopexportableformbuildsolid[])ScopexportableaccumulatesolidArrayObject)
            });
        }
    }
}
