using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B39542EACE59329, NameHash = 0x32C905AD)]
    public class GcSpacePoiEncounterItem : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<NMSString0x10> BlockingMissionIds;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSTemplate EncounterData;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x30 */ public GcSpacePoiEncounterType EncounterType;
        [NMS(Index = 1)]
        /* 0x34 */ public int Weight;
    }
}
