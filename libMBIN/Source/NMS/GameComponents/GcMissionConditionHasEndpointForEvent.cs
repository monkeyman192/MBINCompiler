namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30F7C9060AA17DBA, NameHash = 0x9C35F879928BF0CE)]
    public class GcMissionConditionHasEndpointForEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A EventID;
        [NMS(Index = 1)]
        /* 0x20 */ public float MaxDistance;
    }
}
