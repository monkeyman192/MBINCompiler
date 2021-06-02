using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x9E2E997085841D42, NameHash = 0xC03D7C3C7D972C1E)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        /* 0x080 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 DebugText;
    }
}

