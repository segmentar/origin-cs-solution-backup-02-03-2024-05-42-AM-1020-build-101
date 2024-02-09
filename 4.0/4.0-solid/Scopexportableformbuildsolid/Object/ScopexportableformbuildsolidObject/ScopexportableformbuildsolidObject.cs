using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformbuildsolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableformbuildsolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Scopexportableheadersolid) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Scopexportablebodysolid) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopexportablehierarchynumeratesolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportablehierarchynumeratesolidArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Scopexportableheadersolid) + ':',
                String.Empty + Scopexportableheadersolid,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Scopexportablebodysolid) + ':',
                String.Empty + Scopexportablebodysolid,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ScopexportablehierarchynumeratesolidArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ScopexportablehierarchynumeratesolidArray)
            });
        }
    }
}
