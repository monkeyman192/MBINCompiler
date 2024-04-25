using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x502E9F43682A9C6, NameHash = 0x342750A176F374A4)]
    public class GcGroupCondition : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 1)]
        /* 0x10 */ public bool ORConditions;
    }
}
