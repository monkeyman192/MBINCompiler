using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7052C8556ED13EF2, NameHash = 0x3D59F9B1)]
    public class TkBlackboardDefaultValueBool : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 BlackboardKey;
        [NMS(Index = 0)]
        /* 0x10 */ public TkBlackboardCategory BlackboardCategory;
        [NMS(Index = 2)]
        /* 0x14 */ public bool DefaultValue;
    }
}
