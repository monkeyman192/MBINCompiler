using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x86C6914693276E03, NameHash = 0x8E91F497B8C8D2F3)]
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
