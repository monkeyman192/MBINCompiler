namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7EAE5E8DD0CF3F7, NameHash = 0x7DF5AD147C5460A0)]
    public class GcExperienceTimers : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector2f High;
        [NMS(Index = 4)]
        /* 0x08 */ public Vector2f Low;
        [NMS(Index = 3)]
        /* 0x10 */ public Vector2f Normal;
        [NMS(Index = 0)]
        /* 0x18 */ public int HighChance;
        [NMS(Index = 1)]
        /* 0x1C */ public int LowChance;
    }
}
