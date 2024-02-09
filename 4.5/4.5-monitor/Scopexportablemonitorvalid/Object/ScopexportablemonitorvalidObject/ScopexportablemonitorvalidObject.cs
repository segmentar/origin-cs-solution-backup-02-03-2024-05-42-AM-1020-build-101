using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct Scopexportablemonitorvalid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitorvalid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ScopexportablevalidObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopexportablevalidfileArrayObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ErrorObject) + ':' + ' ' + (Int32)ErrorObject,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ScopexportablevalidfileObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ScopexportablevalidObject) + ':',
                String.Empty + (Scopexportablevalid)ScopexportablevalidObject,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ScopexportablevalidfileArrayObject) + ':',
                String.Empty + (Scopexportablevalidfile[])ScopexportablevalidfileArrayObject,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ScopexportablevalidfileObject) + ':',
                String.Empty + $"<safe><<{(EqualityComparer<Scopexportablevalidfile>.Default.Equals(Scopexportablevalidfile, default) ? String.Empty : ((Scopexportablevalidfile)ScopexportablevalidfileObject).ToString())}>>"
            });
        }
    }
}
