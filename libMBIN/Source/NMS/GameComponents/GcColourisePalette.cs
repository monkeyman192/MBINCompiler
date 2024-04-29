namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6CC798F0157C118, NameHash = 0x6B4DC30B6C22DBE6)]
    public class GcColourisePalette : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour PrimaryColour;
        [NMS(Index = 3)]
        /* 0x10 */ public Colour QuaternaryColour;
        [NMS(Index = 1)]
        /* 0x20 */ public Colour SecondaryColour;
        [NMS(Index = 2)]
        /* 0x30 */ public Colour TernaryColour;
    }
}
