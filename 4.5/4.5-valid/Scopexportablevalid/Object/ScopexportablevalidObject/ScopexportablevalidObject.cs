using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablevalid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableaccumulatesolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableaccumulatesolidArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Scopexportablevalidenum) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Scopexportablevalidnumerate) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ScopexportableaccumulatesolidArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ScopexportableaccumulatesolidArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Scopexportablevalidenum) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablevalidenum),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Scopexportablevalidnumerate) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablevalidnumerate)
            });
        }
    }
}
