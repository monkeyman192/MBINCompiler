namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5D10D418CE2F7DD, NameHash = 0x47C4BE1F468F66AA)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float Time;
        [NMS(Index = 1)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 3)]
        /* 0x84 */ public bool MultiplyTimeBySeasonValue;
        [NMS(Index = 2)]
        /* 0x85 */ public bool SuppressMessages;
    }
}
