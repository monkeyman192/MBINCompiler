using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCCB4AC2CBE23A48, NameHash = 0x9F76738BACABEAD2)]
    public class GcFiendCrimeSpawnData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x00 */ public int[] MaxNum;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x10 */ public int[] MinNum;
        [NMS(Index = 2)]
        /* 0x20 */ public float MaxDist;
        [NMS(Index = 1)]
        /* 0x24 */ public float MinDist;
        [NMS(Index = 0)]
        /* 0x28 */ public GcCreatureTypes Type;
    }
}
