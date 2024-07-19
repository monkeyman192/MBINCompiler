using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DF9BD5F407B516, NameHash = 0x4551B575)]
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 3)]
        /* 0x10 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x14 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x18 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 4)]
        /* 0x1C */ public bool DisableMultiplier;
        [NMS(Index = 5)]
        /* 0x1D */ public bool RewardAsBlobs;
        [NMS(Index = 7)]
        /* 0x1E */ public bool Silent;
        [NMS(Index = 6)]
        /* 0x1F */ public bool UseFuelMultiplier;
        [NMS(Index = 8)]
        /* 0x20 */ public bool UseMissionBoardDifficultyScale;
    }
}
