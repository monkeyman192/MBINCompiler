using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x370, GUID = 0x7C932E4E8ECD9EE0, NameHash = 0xF12C873B2656248)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
