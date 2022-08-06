using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x69FFF37CCA5995E5, NameHash = 0xE4A4F7A4BE98467D)]
    public class GcFrigateTraitIcons : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        public NMSString0x80[] Icons;
    }
}
