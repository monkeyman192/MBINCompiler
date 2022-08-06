using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4FDCEA82E0047EAF, NameHash = 0xA95856C785F7F5CB)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        public GcSubstanceSecondary[] SecondarySubstanceByBiome;

    }
}
