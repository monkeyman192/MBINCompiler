namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43300327698E87B3, NameHash = 0x8093BB6)]
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
