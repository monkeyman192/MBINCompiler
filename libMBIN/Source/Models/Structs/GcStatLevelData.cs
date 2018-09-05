namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
    public class GcStatLevelData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string LevelName;
        [NMS(Size = 0x20)]
        /* 0x20 */ public string OSDLevelName;
        /* 0x40 */ public GcStatValueData Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4C */ public byte[] Padding4C;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string TrophyToUnlock;
    }
}
