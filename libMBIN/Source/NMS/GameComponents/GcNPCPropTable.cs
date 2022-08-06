using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x859CCCFDD95628C8, NameHash = 0x22BD6A8E5AD4C4CB)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Size = 0xD, EnumType = typeof(GcNPCPropTypes.NPCPropEnum))]
        public GcNPCPropInfo[] Props;
    }
}
