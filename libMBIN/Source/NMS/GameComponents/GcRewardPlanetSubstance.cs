namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0FAF4739E2CE5D, NameHash = 0x1316C386517581C1)]
    public class GcRewardPlanetSubstance : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public bool DisableMultiplier;
        /* 0x9 */ public bool RewardAsBlobs;
        /* 0xA */ public bool UseFuelMultiplier;
    }
}
