namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BE77A73D961B88B, NameHash = 0xA420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Percent;
        [NMS(Index = 3)]
        /* 0x4 */ public bool OverrideMissionSeedWithRandomSeed;
        [NMS(Index = 2)]
        /* 0x5 */ public bool OverrideZeroSeed;
        [NMS(Index = 1)]
        /* 0x6 */ public bool Seeded;
    }
}
