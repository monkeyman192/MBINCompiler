using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x8F21EA51746036C0, NameHash = 0xF53E6F170BCA9237)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        /* 0x00 */ public float Thickness;
        /* 0x04 */ public float Speed;
        /* 0x08 */ public float Alpha1;
        /* 0x0C */ public float Alpha2;
        /* 0x10 */ public TkPaletteTexture Colour1;
        /* 0x18 */ public TkPaletteTexture Colour2;
    }
}
