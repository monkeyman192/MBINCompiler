using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0x5983B88C47522ECD, NameHash = 0x79D85DCF556B9E6B)]
    public class GcMissionSequenceWaitForDepots : NMSTemplate       // size: 0x108
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public int AmountMin;
        /* 0x084 */ public int AmountMax;
        /* 0x088 */ public NMSString0x80 DebugText;
    }
}