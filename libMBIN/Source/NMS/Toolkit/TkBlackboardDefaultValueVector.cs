using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA45BE15631682F18, NameHash = 0xD1EFB029)]
    public class TkBlackboardDefaultValueVector : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f DefaultValue;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x20 */ public TkBlackboardCategory BlackboardCategory;
    }
}
