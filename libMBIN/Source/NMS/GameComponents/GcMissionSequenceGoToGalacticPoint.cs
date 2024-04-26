using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF69424E7FAC4765, NameHash = 0xDC7A747D3350B89B)]
    public class GcMissionSequenceGoToGalacticPoint : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcMissionGalacticPoint Target;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
