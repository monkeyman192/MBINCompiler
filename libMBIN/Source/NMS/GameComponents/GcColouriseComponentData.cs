namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4F3CFE49B6B87F2, NameHash = 0x8F7F2EBCF9C0EDF)]
    public class GcColouriseComponentData : NMSTemplate
    {
        /* 0x00 */ public Colour PrimaryColour;
        /* 0x10 */ public Colour QuaternaryColour;
        /* 0x20 */ public Colour SecondaryColour;
        /* 0x30 */ public Colour TernaryColour;
    }
}
