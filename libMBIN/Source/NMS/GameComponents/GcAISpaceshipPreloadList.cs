using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE20FE7AAC6C75AD3, NameHash = 0xC546551B048ACC33)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcAISpaceshipPreloadCacheData> Cache;
        [NMS(Index = 0)]
        /* 0x10 */ public GcRealityCommonFactions Faction;
    }
}
