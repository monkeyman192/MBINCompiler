using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FDA68F336A016C4, NameHash = 0xA368BE81)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
    }
}
