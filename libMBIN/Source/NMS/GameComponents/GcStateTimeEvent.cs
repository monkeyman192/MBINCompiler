namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91DB1B3A46C998BE, NameHash = 0xED658C61)]
    public class GcStateTimeEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float RandomSeconds;
        [NMS(Index = 0)]
        /* 0x4 */ public float Seconds;
        [NMS(Index = 2)]
        /* 0x8 */ public bool UseMissionClock;
    }
}
