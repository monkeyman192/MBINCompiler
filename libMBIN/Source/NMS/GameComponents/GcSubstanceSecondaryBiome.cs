using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A0, GUID = 0x4FDCEA82E0047EAF)]
    public class GcSubstanceSecondaryBiome : NMSTemplate
    {
        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        public GcSubstanceSecondary[] SecondarySubstanceByBiome;

    }
}
