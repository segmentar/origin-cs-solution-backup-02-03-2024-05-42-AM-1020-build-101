using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablemonitorexpression) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + ExpressionObject + ':' + ' ' + (String)ExpressionObject,
                String.Empty + '}'
            });
        }
    }
}
