namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6809A50B1268BBE, NameHash = 0xA420A86F131CF88)]
    public class GcMissionConditionPercentageChance : NMSTemplate
    {
        /* 0x0 */ public int Percent;
        /* 0x4 */ public bool OverrideMissionSeedWithRandomSeed;
        /* 0x5 */ public bool OverrideZeroSeed;
        /* 0x6 */ public bool Seeded;
    }
}
