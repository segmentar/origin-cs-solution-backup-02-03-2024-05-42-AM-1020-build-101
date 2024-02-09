using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalidnumerate
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablevalidnumerate) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + nameof(Valid) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportablehierarchynumeratesolid, Boolean>(Valid).Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Valid) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportablehierarchynumeratesolid, Boolean>(Valid))
            });
        }
    }
}
