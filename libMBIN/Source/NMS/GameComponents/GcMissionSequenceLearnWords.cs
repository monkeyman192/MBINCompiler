using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x55E557A8BDD48B98, NameHash = 0x2A6B4FAF511D932F)]
    public class GcMissionSequenceLearnWords : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public int Amount;
        /* 0x084 */ public NMSString0x80 DebugText;
    }
}
