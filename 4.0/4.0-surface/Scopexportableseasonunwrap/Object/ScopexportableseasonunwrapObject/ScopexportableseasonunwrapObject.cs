using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableseasonunwrap
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportableseasonunwrap) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(RequireShould) + ':' + ' ' + RequireShould,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(OptionShould) + ':' + ' ' + OptionShould,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(AnyShould) + ':' + ' ' + AnyShould,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(SomeShould) + ':' + ' ' + SomeShould,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(DivideShould) + ':' + ' ' + DivideShould,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(SequenceShould) + ':' + ' ' + SequenceShould,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(SentenceShould) + ':' + ' ' + SentenceShould,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ParagraphShould) + ':' + ' ' + ParagraphShould,
                String.Empty + '}'
            });
        }
    }
}
