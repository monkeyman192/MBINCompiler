using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51365CD3885CB982, NameHash = 0x8EC9FC58B2383BF6)]
    public class GcMissionConditionRequestedPhoto : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Biome;
    }
}
