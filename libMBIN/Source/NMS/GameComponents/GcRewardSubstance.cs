using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC736968D55D1468E, NameHash = 0x3DDFD92393C0D347)]
    public class GcRewardSubstance : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCategory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public int ItemLevel;
        /* 0x0C */ public int AmountMin;
        /* 0x10 */ public int AmountMax;
        /* 0x14 */ public float HardModeMultiplier;
        /* 0x18 */ public bool DisableMultiplier;
        /* 0x19 */ public bool RewardAsBlobs;
        /* 0x1A */ public bool UseFuelMultiplier;
    }
}