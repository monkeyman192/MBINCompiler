using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68F12D6DECB242DD, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A SpawnLocatorScanEvent;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 AppearAnim;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Archetype;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x10 SpawnLocator;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x50 */ public int[] MaxNum;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x60 */ public int[] MinNum;
        [NMS(Index = 9)]
        /* 0x70 */ public float ActiveTime;
        // size: 0x3
        public enum FaceDirEnum : uint {
            Random,
            TowardsPlayer,
            SpawnerAt,
        }
        [NMS(Index = 4)]
        /* 0x74 */ public FaceDirEnum FaceDir;
        [NMS(Index = 6)]
        /* 0x78 */ public float MaxDist;
        [NMS(Index = 5)]
        /* 0x7C */ public float MinDist;
    }
}
