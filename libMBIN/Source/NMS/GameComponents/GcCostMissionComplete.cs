namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3DA1DB34521FA9D, NameHash = 0x2AA270B1FED04EB4)]
    public class GcCostMissionComplete : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A TextOverride;
        /* 0x20 */ public NMSString0x10 Cost;
        /* 0x30 */ public bool HideIfCompleted;
    }
}
