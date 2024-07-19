namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC82D63989865E595, NameHash = 0x901E9005)]
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
