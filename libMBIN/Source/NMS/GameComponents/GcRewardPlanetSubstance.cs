namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0FAF4739E2CE5D, NameHash = 0x1316C386517581C1)]
    public class GcRewardPlanetSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public bool DisableMultiplier;
        [NMS(Index = 3)]
        /* 0x9 */ public bool RewardAsBlobs;
        [NMS(Index = 4)]
        /* 0xA */ public bool UseFuelMultiplier;
    }
}
