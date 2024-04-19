using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFB451007B628183, NameHash = 0xF3F4ABE3661F3779)]
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int AmountMax;
        /* 0x14 */ public int AmountMin;
        /* 0x18 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x1C */ public bool DisableMultiplier;
        /* 0x1D */ public bool RewardAsBlobs;
        /* 0x1E */ public bool Silent;
        /* 0x1F */ public bool UseFuelMultiplier;
        /* 0x20 */ public bool UseMissionBoardDifficultyScale;
    }
}
