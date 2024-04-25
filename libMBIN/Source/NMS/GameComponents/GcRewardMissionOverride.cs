namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5BA3E9F1DD880AF9, NameHash = 0xCFC064FBFD501A40)]
    public class GcRewardMissionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 ForceLocalMissionSelection;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Reward;
    }
}
