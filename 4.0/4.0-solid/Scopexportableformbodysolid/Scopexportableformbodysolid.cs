using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformbodysolid
    {
        public Object Object;

        public Int32 Mid;

        public Scopexportablestringsafe Form;

        public Scopexportablestringsafe Hierarchy;

        public Scopexportablestringarraysafe PortalArray;

        public Scopexportablestringarraysafe BindArray;

        public Scopexportablestringsafe Body;

        public Scopexportablestringarraysafe BodyArray;

        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableformbodysolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "solid",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Mid) + ':' + ' ' + Mid,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Form) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Form) + ':' + ' ' + Form.ValueSafe,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Hierarchy) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Hierarchy) + ':' + ' ' + Hierarchy.ValueSafe,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(PortalArray) + ':' + ' ' + ". . ." + ' ' + $"<{PortalArray.Value.Length}>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(BindArray) + ':' + ' ' + ". . ." + ' ' + $"<{BindArray.Value.Length}>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(Body) + ':' + ' ' + Body.ValueSafe,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(BodyArray) + ':' + ' ' + ". . ." + ' ' + $"<{BodyArray.Value.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(PortalArray) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), PortalArray.ValueSafe)}>>",
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(BindArray) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), BindArray.ValueSafe)}>>",
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(BodyArray) + ':',
                String.Empty + $"<safe><<{String.Join('\n'.ToString(), BodyArray.ValueSafe)}>>"
            });
        }
    }
}
