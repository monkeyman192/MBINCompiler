namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC207A55F7112F202, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TechId;
        [NMS(Index = 1)]
        /* 0x10 */ public bool AutoPin;
        [NMS(Index = 3)]
        /* 0x11 */ public bool HideInSeasonRewards;
        [NMS(Index = 2)]
        /* 0x12 */ public bool Silent;
    }
}
