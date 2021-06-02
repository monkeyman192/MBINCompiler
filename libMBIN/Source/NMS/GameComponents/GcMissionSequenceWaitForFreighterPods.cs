using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x1B655E6ECEF95A07, NameHash = 0x779C608FD9761375)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate        // size: 0x104
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public int Amount;
        /* 0x084 */ public NMSString0x80 DebugText;
    }
}