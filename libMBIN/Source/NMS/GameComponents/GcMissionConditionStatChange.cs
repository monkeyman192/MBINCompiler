namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x557EE66B77DA55A8, NameHash = 0xE4D7E6B8)]
    public class GcMissionConditionStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 StatGroup;
    }
}
