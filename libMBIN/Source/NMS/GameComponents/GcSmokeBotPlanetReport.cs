using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3991C31155BA5CB8, NameHash = 0x778378F86BB2392C)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSmokeBotStats PlanetStats;
        [NMS(Index = 0)]
        /* 0x90 */ public ulong UA;
    }
}
