using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0xE06E78532B6DAA85, NameHash = 0x88DEFBD52206A298)]
    public class GcMissionSequenceWaitForShips : NMSTemplate        // size: 0x108
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcRealityCommonFactions Type;
        /* 0x084 */ public int Count;
        /* 0x088 */ public NMSString0x80 DebugText;
    }
}