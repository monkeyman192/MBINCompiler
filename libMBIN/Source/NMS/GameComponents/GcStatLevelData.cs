using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFEFF310D0058C71, NameHash = 0xECC1CDECFE5FC437)]
    public class GcStatLevelData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LevelName;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A LevelNameUpper;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x20A OSDLevelName;
        [NMS(Index = 4)]
        /* 0x60 */ public NMSString0x10 TrophyToUnlock;
        [NMS(Index = 3)]
        /* 0x70 */ public GcStatValueData Value;
    }
}
