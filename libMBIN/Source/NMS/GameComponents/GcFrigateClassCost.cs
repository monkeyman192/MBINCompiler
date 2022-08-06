using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x25C9483BA5237DCE, NameHash = 0x8505F02597BABF0)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        public int[] Cost;
    }
}