using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct Scopexportablevalid
    {
        public static Scopexportablevalid ForgeDefault(Scopexportableformbuildsolid[] array_SCOPEXPORTABLEACCUMULATESOLID)
        {
            Scopexportablevalid scopexportablevalidResult = default;

            Scopexportablevalid scopexportablevalid;

            scopexportablevalid = new Scopexportablevalid();

            scopexportablevalid.ScopexportableaccumulatesolidArray = array_SCOPEXPORTABLEACCUMULATESOLID;

            var deflect = new IEnumerable[2];

            deflect[0] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportableformbuildsolid, Boolean>();

            deflect[1] = Scopexportabledictionary.ScopexportabledictionaryDictionaryEmptyDispenser<Scopexportablehierarchynumeratesolid, Boolean>();

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEACCUMULATESOLID in array_SCOPEXPORTABLEACCUMULATESOLID)
            {
                Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(deflect[0]).Add(value_SCOPEXPORTABLEACCUMULATESOLID, false);

                continue;
            }

            foreach (Scopexportableformbuildsolid value_SCOPEXPORTABLEACCUMULATESOLID in array_SCOPEXPORTABLEACCUMULATESOLID)
            {
                foreach (Scopexportablehierarchynumeratesolid scopexportablehierarchynumeratesolid in value_SCOPEXPORTABLEACCUMULATESOLID.ScopexportablehierarchynumeratesolidArray)
                {
                    Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportablehierarchynumeratesolid, Boolean>(deflect[1]).Add(scopexportablehierarchynumeratesolid, false);
                    
                    continue;
                }

                continue;
            }

            Scopexportablevalidenum scopexportablevalidenum;

            scopexportablevalidenum = new Scopexportablevalidenum();

            scopexportablevalidenum.Valid = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformbuildsolid, Boolean>(deflect[0]);

            Scopexportablevalidnumerate scopexportablevalidnumerate;

            scopexportablevalidnumerate = new Scopexportablevalidnumerate();

            scopexportablevalidnumerate.Valid = Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportablehierarchynumeratesolid, Boolean>(deflect[1]);
            
            scopexportablevalid.Scopexportablevalidenum = scopexportablevalidenum;

            scopexportablevalid.Scopexportablevalidnumerate = scopexportablevalidnumerate;

            scopexportablevalidResult = scopexportablevalid;

            return scopexportablevalidResult;
        }
    }
}
