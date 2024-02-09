using Core;

namespace Core 
{
    using System;

    public partial struct Scopexportablevalidenum
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablevalidenum) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Valid) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(Valid).Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Valid) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(Valid))
            });
        }
    }
}
