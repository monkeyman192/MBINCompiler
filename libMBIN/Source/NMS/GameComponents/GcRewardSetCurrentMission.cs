namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF29DE9D73CE2FBC2, NameHash = 0xD8850AC59C3175E1)]
    public class GcRewardSetCurrentMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 2)]
        /* 0x10 */ public bool Seeded;
        [NMS(Index = 1)]
        /* 0x11 */ public bool Silent;
    }
}
