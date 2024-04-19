using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B0FAF5D4550E94B, NameHash = 0x15A053481CA45D03)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x000 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x1B0 */ public GcCreatureRoleFilenameList[] BiomeFiles;
        /* 0x2B0 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0x2C0 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0x2D0 */ public GcCreatureRoleFilenameList RobotFiles;
        /* 0x2E0 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0x2F0 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x300 */ public float[] LifeChance;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0x310 */ public float[] RoleFrequencyModifiers;
    }
}
