using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5ED254A8BB4DE12A, NameHash = 0xF10587272870E7F4)]
    public class GcNGuiElementData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x58 */ public NMSString0x10 PresetID;
        [NMS(Index = 3)]
        /* 0x68 */ public TkNGuiForcedStyle ForcedStyle;
        [NMS(Index = 2)]
        /* 0x6C */ public bool IsHidden;
    }
}
