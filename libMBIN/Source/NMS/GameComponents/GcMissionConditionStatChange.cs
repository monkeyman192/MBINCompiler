namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x557EE66B77DA55A8, NameHash = 0x9481201C43F8E7A3)]
    public class GcMissionConditionStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 StatGroup;
    }
}
