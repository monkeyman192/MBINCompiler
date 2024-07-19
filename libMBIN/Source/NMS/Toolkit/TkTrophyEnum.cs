namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDCDC4D1713C4B17A, NameHash = 0xEC9E3FD8)]
    public class TkTrophyEnum : NMSTemplate
    {
        // size: 0x6
        public enum TrophyEnum : uint {
            None = 0xFFFFFFFF,
            Trophy0 = 0x0,
            Trophy1 = 0x1,
            Trophy2 = 0x2,
            Trophy3 = 0x3,
            Trophy4 = 0x4,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TrophyEnum Trophy;
    }
}
