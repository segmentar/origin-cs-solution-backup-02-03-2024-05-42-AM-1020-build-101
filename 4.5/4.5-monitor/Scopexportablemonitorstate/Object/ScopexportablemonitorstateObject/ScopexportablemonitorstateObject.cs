using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorstate
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitorstate) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsRunObject) + ':' + ' ' + (Boolean)IsRunObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsPauseObject) + ':' + ' ' + (Boolean)IsPauseObject,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SkipShouldObject) + ':' + ' ' + (Boolean)SkipShouldObject,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(RestartShouldObject) + ':' + ' ' + (Boolean)RestartShouldObject, 
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(IntervalObject) + ':' + ' ' + (Int32)IntervalObject,
                String.Empty + '}'
            });
        }
    }
}
