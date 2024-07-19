using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7264F11AF9C78188, NameHash = 0x1C2C090B)]
    public class TkBlackboardDefaultValueFloat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        [NMS(Index = 2)]
        /* 0x14 */ public float DefaultValue;
    }
}
