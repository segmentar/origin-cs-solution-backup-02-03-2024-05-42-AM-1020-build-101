using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct Scopexportablemonitorfilearray
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitorfilearray) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableaccumulatesolidStackObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicStackCastDispenser(ScopexportableaccumulatesolidStackObject).Count}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FileInfoArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((FileInfo[])FileInfoArrayObject).Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StackObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicStackCastDispenser(StackObject).Count}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(TextObject) + ':' + ' ' + (String)TextObject,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileInfoArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Object[])FileInfoArrayObject),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(StackObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicStackCastDispenser(StackObject).ToArray()),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ScopexportableaccumulatesolidStackObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicStackCastDispenser(ScopexportableaccumulatesolidStackObject))
            });
        }
    }
}
