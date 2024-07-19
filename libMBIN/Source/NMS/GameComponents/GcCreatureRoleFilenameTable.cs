using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36A90583B8D930EC, NameHash = 0x6668980E)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x000 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x1C0 */ public GcCreatureRoleFilenameList[] BiomeFiles;
        [NMS(Index = 4)]
        /* 0x2C0 */ public GcCreatureRoleFilenameList AirFiles;
        [NMS(Index = 3)]
        /* 0x2D0 */ public GcCreatureRoleFilenameList CaveFiles;
        [NMS(Index = 5)]
        /* 0x2E0 */ public GcCreatureRoleFilenameList RobotFiles;
        [NMS(Index = 1)]
        /* 0x2F0 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        [NMS(Index = 2)]
        /* 0x300 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x310 */ public float[] LifeChance;
        [NMS(Index = 8, Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0x320 */ public float[] RoleFrequencyModifiers;
    }
}
