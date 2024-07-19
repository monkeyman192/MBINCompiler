namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13409E69C59DDB9B, NameHash = 0x4F937484)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool RequiresFullFireteam;
    }
}
