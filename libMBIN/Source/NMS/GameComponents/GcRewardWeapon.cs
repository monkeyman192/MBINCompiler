using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7537C0789888A6DC, NameHash = 0xDF91F2B5F746FB61)]
    public class GcRewardWeapon : NMSTemplate
    {
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcMultitoolPoolType.MultiToolPoolTypeEnum))]
        /* 0x00 */ public float[] PoolTypeProbabilities;
        [NMS(Index = 0)]
        /* 0x10 */ public int ItemLevel;
        [NMS(Index = 8)]
        /* 0x14 */ public GcInteractionMissionState SetInteractionStateOnSuccess;
        [NMS(Index = 3)]
        /* 0x18 */ public bool ForceFixed;
        [NMS(Index = 1)]
        /* 0x19 */ public bool MarkInteractionComplete;
        [NMS(Index = 6)]
        /* 0x1A */ public bool OnlyUseNextInteractionOnSuccess;
        [NMS(Index = 5)]
        /* 0x1B */ public bool ReinteractOnDecline;
        [NMS(Index = 4)]
        /* 0x1C */ public bool RequeueInteraction;
        [NMS(Index = 2)]
        /* 0x1D */ public bool UsePlanetSeed;
    }
}
