using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC2699349ED9053DD, NameHash = 0x45A1CDC5CD2FB6DC)]
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
