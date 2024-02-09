using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct Scopexportablemonitorquery
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablemonitorquery) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(LinkedListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablehierarchynumeratesolid>(LinkedListObject).Count}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ErrorObject) + ':' + ' ' + (Int32)ErrorObject,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ScopexportablehierarchynumeratesolidObject) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LinkedListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablehierarchynumeratesolid>(LinkedListObject)),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ScopexportablehierarchynumeratesolidObject) + ':',
                String.Empty + (EqualityComparer<Scopexportablehierarchynumeratesolid>.Default.Equals((Scopexportablehierarchynumeratesolid)ScopexportablehierarchynumeratesolidObject, default) ? String.Empty : ((Scopexportablehierarchynumeratesolid)ScopexportablehierarchynumeratesolidObject).ToString())
            });
        }
    }
}
