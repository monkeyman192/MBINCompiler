namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7EAE5E8DD0CF3F7, NameHash = 0x7DF5AD147C5460A0)]
    public class GcExperienceTimers : NMSTemplate
    {
        /* 0x00 */ public Vector2f High;
        /* 0x08 */ public Vector2f Low;
        /* 0x10 */ public Vector2f Normal;
        /* 0x18 */ public int HighChance;
        /* 0x1C */ public int LowChance;
    }
}
