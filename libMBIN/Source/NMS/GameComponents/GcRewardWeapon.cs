using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7537C0789888A6DC, NameHash = 0xDF91F2B5F746FB61)]
    public class GcRewardWeapon : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcMultitoolPoolType.MultiToolPoolTypeEnum))]
        /* 0x00 */ public float[] PoolTypeProbabilities;
        /* 0x10 */ public int ItemLevel;
        /* 0x14 */ public GcInteractionMissionState SetInteractionStateOnSuccess;
        /* 0x18 */ public bool ForceFixed;
        /* 0x19 */ public bool MarkInteractionComplete;
        /* 0x1A */ public bool OnlyUseNextInteractionOnSuccess;
        /* 0x1B */ public bool ReinteractOnDecline;
        /* 0x1C */ public bool RequeueInteraction;
        /* 0x1D */ public bool UsePlanetSeed;
    }
}
