using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B41A5488730D145, NameHash = 0xAD42CCD8)]
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
