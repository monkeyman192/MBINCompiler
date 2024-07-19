using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x803BBA33B76F2637, NameHash = 0x5A86E9AA)]
    public class GcMissionConditionRequestedPhoto : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Biome;
    }
}
