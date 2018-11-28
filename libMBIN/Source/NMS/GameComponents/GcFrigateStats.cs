using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x5C119C6B02E613B)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS( EnumType = typeof( GcFrigateStatType.FrigateStatTypeEnum ) )]
        /* 0x00 */ public GcFrigateStatRange[] Stats;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string InitialTrait;
    }
}
