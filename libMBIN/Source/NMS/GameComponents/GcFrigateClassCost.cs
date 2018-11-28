using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x25C9483BA5237DCE)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS( EnumType = typeof( GcFrigateClass.FrigateClassEnum ) )]
        public int[] Cost;
    }
}
