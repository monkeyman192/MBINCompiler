namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x186ECDA43BB7EA4B, NameHash = 0x9B8F010E)]
    public class GcNGuiSpecialTextImageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 5)]
        /* 0x10 */ public VariableSizeString Path;
        [NMS(Index = 4)]
        /* 0x20 */ public Vector2f Size;
        [NMS(Index = 2)]
        /* 0x28 */ public float HeightModifier;
        [NMS(Index = 1)]
        /* 0x2C */ public float ScaleFromFont;
        [NMS(Index = 3)]
        /* 0x30 */ public bool UseFontColour;
    }
}
