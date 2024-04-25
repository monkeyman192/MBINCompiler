namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA2014717593869BC, NameHash = 0x51D536C649733342)]
    public class TkTrophyEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TrophyId;
        [NMS(Index = 1)]
        /* 0x10 */ public int Ps4Id;
        [NMS(Index = 2)]
        /* 0x14 */ public NMSString0x40 PCId;
        [NMS(Index = 3)]
        /* 0x54 */ public NMSString0x20 XboxOneId;
    }
}
