using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x61509A87E8DC0D50, NameHash = 0xF10587272870E7F4)]
    public class GcNGuiElementData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 PresetID;
        /* 0x20 */ public bool IsHidden;
        /* 0x28 */ public GcNGuiLayoutData Layout;
    }
}
