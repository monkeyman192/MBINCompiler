using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF78D54B32ABA4F75, NameHash = 0x76E523097495B90)]
    public class GcPlayerExperienceSpawnData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SpawnLocatorScanEvent;
        /* 0x20 */ public NMSString0x10 AppearAnim;
        /* 0x30 */ public NMSString0x10 Archetype;
        /* 0x40 */ public NMSString0x10 SpawnLocator;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x50 */ public int[] MaxNum;
        [NMS(Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x60 */ public int[] MinNum;
        /* 0x70 */ public float ActiveTime;
        // size: 0x3
        public enum FaceDirEnum : uint {
            Random,
            TowardsPlayer,
            SpawnerAt,
        }
        /* 0x74 */ public FaceDirEnum FaceDir;
        /* 0x78 */ public float MaxDist;
        /* 0x7C */ public float MinDist;
    }
}
