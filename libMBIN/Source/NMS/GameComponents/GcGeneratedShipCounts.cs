using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x3EAE70796B38879D, NameHash = 0x46AEF7A8E9B9A7D8)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Size = 0x6)]
        public int[] Counts;
    }
}