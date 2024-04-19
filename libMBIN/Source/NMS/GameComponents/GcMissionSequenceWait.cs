namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA86FC3BDC40CF0D4, NameHash = 0x47C4BE1F468F66AA)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x00 */ public float Time;
        /* 0x04 */ public NMSString0x80 DebugText;
        /* 0x84 */ public bool MultiplyTimeBySeasonValue;
        /* 0x85 */ public bool SuppressMessages;
    }
}
