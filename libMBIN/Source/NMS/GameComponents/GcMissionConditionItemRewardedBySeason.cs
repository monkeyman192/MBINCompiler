namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9681A2D7D18E7A4E, NameHash = 0xC3097BD269CEC211)]
    public class GcMissionConditionItemRewardedBySeason : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ItemID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool TakeIDFromSeasonData;
    }
}
