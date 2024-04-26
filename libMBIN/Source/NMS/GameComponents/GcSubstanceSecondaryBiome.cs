using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D54C9A287EAD2CE, NameHash = 0xA95856C785F7F5CB)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x0 */ public GcSubstanceSecondary[] SecondarySubstanceByBiome;
    }
}
