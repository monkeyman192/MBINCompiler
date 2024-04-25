namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7026F5C51A6E08D0, NameHash = 0xF594D54B778D6517)]
    public class GcNGuiSpecialTextImageData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector2f Size;
        [NMS(Index = 3)]
        /* 0x18 */ public NMSString0x80 Path;
        [NMS(Index = 1)]
        /* 0x98 */ public bool ScaleToFitFont;
    }
}
