using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x491EE59D67E7FF8E, NameHash = 0xF53E6F170BCA9237)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        /* 0x00 */ public TkPaletteTexture Colour1;
        /* 0x08 */ public TkPaletteTexture Colour2;
        /* 0x10 */ public float Alpha1;
        /* 0x14 */ public float Alpha2;
        /* 0x18 */ public float Speed;
        /* 0x1C */ public float Thickness;
    }
}
