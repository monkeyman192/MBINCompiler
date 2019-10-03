using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9E2E997085841D42, NameHash = 0xC03D7C3C7D972C1E)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}


