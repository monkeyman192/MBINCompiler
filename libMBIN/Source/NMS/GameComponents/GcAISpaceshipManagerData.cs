using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C6FE3E5B5CFA87E, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x00 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
        [NMS(Index = 1)]
        /* 0x50 */ public GcAISpaceshipModelData SentinelCrashSiteShip;
    }
}
