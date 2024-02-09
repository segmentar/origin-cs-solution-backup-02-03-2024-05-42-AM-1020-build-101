using Core;

namespace Core
{
    using System;

    public partial class Bootxportablemain
    {
        public static void Main(Scopexportableformbuildsolid value_SCOPEXPORTABLEACCUMULATESOLID, Boolean answer_SYNC_should, Boolean answer_DEBUG_should)
        {
            if (answer_SYNC_should is true)
            {
                var value = Expressionxportableapi.LoadFromExpressionSystemFull();

                var list = Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value.LayerArrayListObject);

                foreach (Scopexportablehierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEACCUMULATESOLID.ScopexportablehierarchynumeratesolidArray)
                {
                    var inflect = new Object[2];

                    inflect[0] = new ExpressionxportableSimple(scopexportablehierarchynumeratesolid.Link.Value, default).Result;

                    inflect[1] = new ExpressionxportableSimple(scopexportablehierarchynumeratesolid.Identity.Value, default).Result;

                    Scopexportablemagic.ScopexportablemagicArrayListCastDispenser(((Expressionxportable)inflect[0]).LayerArrayListObject).Add(inflect[1]);

                    list.Add(inflect[0]);

                    continue;
                }

                Expressionxportableapi.ScheduleText(value, value_SCOPEXPORTABLEACCUMULATESOLID.Scopexportablebodysolid.Body.Value);

                Expressionxportableapi.ReloadInExpressionSystemFull(value);
            }
            else
                "false".ToString();

            if (answer_DEBUG_should is true)
            {
                var value = Expressionxportableapi.LoadFromExpressionSystemFull();

                Scopexportablelog.Log(value);
            }  
            else
                "false".ToString();

            return;
        }
    }
}
