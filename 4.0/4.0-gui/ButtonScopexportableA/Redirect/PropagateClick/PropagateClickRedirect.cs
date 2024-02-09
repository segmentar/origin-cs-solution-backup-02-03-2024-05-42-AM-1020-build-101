using Core;

namespace Core
{
    using System;

    public partial class ButtonScopexportableA
    {
        public static void PropagateClickRedirect(Object sender, EventArgs e)
        {
            var reflect = (ButtonScopexportableA)(sender as Object);

            ScopexportableCode.FormDirection formDirection;

            switch (reflect.Name)
            {
                case Scopexportablestoredirection.EntityTop:
                    formDirection = ScopexportableCode.FormDirection.Top;
                    break;

                case Scopexportablestoredirection.EntityBottom:
                    formDirection = ScopexportableCode.FormDirection.Bottom;
                    break;

                case Scopexportablestoredirection.EntityLeft:
                    formDirection = ScopexportableCode.FormDirection.Left;
                    break;

                case Scopexportablestoredirection.EntityRight:
                    formDirection = ScopexportableCode.FormDirection.Right;
                    break;

                default:
                    formDirection = ScopexportableCode.FormDirection.Unset;
                    break;
            }

            var result = reflect.FindForm();

            FormScopexportableA formScopexportable;

            formScopexportable = new FormScopexportableA();

            formScopexportable.Scopexportablemonitorcontext.Owner = (FormScopexportableA)result;

            formScopexportable.Scopexportablemonitorcontext.FormDirection = formDirection;

            formScopexportable.Show(result);

            return;
        }
    }
}
