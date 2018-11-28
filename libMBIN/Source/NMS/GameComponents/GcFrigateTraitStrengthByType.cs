using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x320, GUID = 0x7C932E4E8ECD9EE0)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS( EnumType = typeof( GcFrigateStatType.FrigateStatTypeEnum ) )]
        public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
