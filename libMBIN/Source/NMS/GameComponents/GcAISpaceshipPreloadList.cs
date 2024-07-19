using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFAEDEFDE51E608D8, NameHash = 0xE2E9147)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcAISpaceshipPreloadCacheData> Cache;
        [NMS(Index = 0)]
        /* 0x10 */ public GcRealityCommonFactions Faction;
    }
}
