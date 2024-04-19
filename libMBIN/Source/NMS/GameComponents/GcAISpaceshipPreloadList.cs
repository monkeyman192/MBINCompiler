using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62AF5ABD2941E17E, NameHash = 0xC546551B048ACC33)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        /* 0x00 */ public List<GcAISpaceshipPreloadCacheData> Cache;
        /* 0x10 */ public GcRealityCommonFactions Faction;
    }
}
