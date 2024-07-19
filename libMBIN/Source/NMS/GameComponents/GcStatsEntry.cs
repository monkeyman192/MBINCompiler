using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71485F3B3C731B25, NameHash = 0x54437A2E)]
    public class GcStatsEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x10 BaseTechID;
        [NMS(Index = 3)]
        /* 0x20 */ public float RangeMax;
        [NMS(Index = 2)]
        /* 0x24 */ public float RangeMin;
        [NMS(Index = 0)]
        /* 0x28 */ public GcStatsTypes Type;
        [NMS(Index = 4)]
        /* 0x2C */ public bool LessIsBetter;
    }
}
