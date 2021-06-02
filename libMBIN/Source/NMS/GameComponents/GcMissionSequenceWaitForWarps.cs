using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x7CF47685DC6899D2, NameHash = 0x720D90D0F7901AA2)]
    public class GcMissionSequenceWaitForWarps : NMSTemplate        // size: 0x104
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x08 */ public int Amount;
        /* 0x084 */ public NMSString0x80 DebugText;
    }
}