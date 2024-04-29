using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8CF854E599EEF1E, NameHash = 0xF53E6F170BCA9237)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public TkPaletteTexture Colour1;
        [NMS(Index = 5)]
        /* 0x08 */ public TkPaletteTexture Colour2;
        [NMS(Index = 2)]
        /* 0x10 */ public float Alpha1;
        [NMS(Index = 3)]
        /* 0x14 */ public float Alpha2;
        [NMS(Index = 1)]
        /* 0x18 */ public float Speed;
        [NMS(Index = 0)]
        /* 0x1C */ public float Thickness;
    }
}
