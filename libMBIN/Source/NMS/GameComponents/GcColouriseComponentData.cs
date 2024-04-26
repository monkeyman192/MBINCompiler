namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4F3CFE49B6B87F2, NameHash = 0x8F7F2EBCF9C0EDF)]
    public class GcColouriseComponentData : NMSTemplate
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
