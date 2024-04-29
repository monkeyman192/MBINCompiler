namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA19B935DD6A73F02, NameHash = 0x318F85B4830D293D)]
    public class GcJourneyMedalTiers : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Bronze;
        [NMS(Index = 3)]
        /* 0x4 */ public int Gold;
        [NMS(Index = 0)]
        /* 0x8 */ public int None;
        [NMS(Index = 2)]
        /* 0xC */ public int Silver;
    }
}
