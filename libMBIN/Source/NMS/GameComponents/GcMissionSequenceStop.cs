using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x6E9A343B43BE870A, NameHash = 0x9B3472E4293AC465)]
    public class GcMissionSequenceStop : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x80 DebugText;
    }
}
