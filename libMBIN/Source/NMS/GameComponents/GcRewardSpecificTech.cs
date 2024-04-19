namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF6C5F7CE276AFA, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TechId;
        /* 0x10 */ public bool AutoPin;
        /* 0x11 */ public bool HideInSeasonRewards;
        /* 0x12 */ public bool Silent;
    }
}
