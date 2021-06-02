using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0x7DE24E8867B9FCB4, NameHash = 0xF10587272870E7F4)]
    public class GcNGuiElementData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 PresetID;
        /* 0x20 */ public bool IsHidden;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x21 */ public byte[] Padding21;
        /* 0x28 */ public GcNGuiLayoutData Layout;
    }
}
