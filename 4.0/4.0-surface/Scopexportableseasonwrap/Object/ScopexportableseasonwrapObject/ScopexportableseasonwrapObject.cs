using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableseasonwrap
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableseasonwrap) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(SummerIs) + ':' + ' ' + SummerIs,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(AutumnIs) + ':' + ' ' + AutumnIs,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SpringIs) + ':' + ' ' + SpringIs,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(WinterIs) + ':' + ' ' + WinterIs,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(SummerHas) + ':' + ' ' + SummerHas,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(AutumnHas) + ':' + ' ' + AutumnHas,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(SpringHas) + ':' + ' ' + SpringHas,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(WinterHas) + ':' + ' ' + WinterHas,
                String.Empty + '}'
            });
        }
    }
}
