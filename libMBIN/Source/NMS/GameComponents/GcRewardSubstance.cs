using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14FFC7609444086C, NameHash = 0x3DDFD92393C0D347)]
    public class GcRewardSubstance : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int AmountMax;
        [NMS(Index = 3)]
        /* 0x04 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x08 */ public GcRealitySubstanceCategory ItemCatagory;
        [NMS(Index = 2)]
        /* 0x0C */ public int ItemLevel;
        [NMS(Index = 1)]
        /* 0x10 */ public GcRarity ItemRarity;
        [NMS(Index = 5)]
        /* 0x14 */ public bool DisableMultiplier;
        [NMS(Index = 6)]
        /* 0x15 */ public bool RewardAsBlobs;
        [NMS(Index = 7)]
        /* 0x16 */ public bool UseFuelMultiplier;
    }
}
