using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x19FDFD13870CBA06, NameHash = 0x4872A14D)]
    public class GcHeavyAirSettingValues : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Colour ForceColour1;
        [NMS(Index = 8)]
        /* 0x10 */ public Colour ForceColour2;
        [NMS(Index = 4)]
        /* 0x20 */ public TkPaletteTexture Colour1;
        [NMS(Index = 5)]
        /* 0x28 */ public TkPaletteTexture Colour2;
        [NMS(Index = 2)]
        /* 0x30 */ public float Alpha1;
        [NMS(Index = 3)]
        /* 0x34 */ public float Alpha2;
        [NMS(Index = 1)]
        /* 0x38 */ public float Speed;
        [NMS(Index = 0)]
        /* 0x3C */ public float Thickness;
        [NMS(Index = 6)]
        /* 0x40 */ public bool ForceColour;
        [NMS(Index = 9)]
        /* 0x41 */ public bool ReduceThicknessWithCloudCoverage;
    }
}
