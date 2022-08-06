using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB3B0E9C5F3659571, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public float WaitTime;
        /* 0x084 */ public bool BlockTimedScans;
        /* 0x085 */ public bool RequiresMissionActive;
        /* 0x086 */ public NMSString0x80 DebugText;
    }
}