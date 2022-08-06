using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD049F5710295C1E0, NameHash = 0x15A053481CA45D03)]
    public class GcCreatureRoleFilenameTable : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcCreatureRoleFilenameList[] BiomeFiles;
        /* 0x100 */ public GcCreatureRoleFilenameList UnderwaterFiles;
        /* 0x110 */ public GcCreatureRoleFilenameList UnderwaterFilesExtra;
        /* 0x120 */ public GcCreatureRoleFilenameList CaveFiles;
        /* 0x130 */ public GcCreatureRoleFilenameList AirFiles;
        /* 0x140 */ public GcCreatureRoleFilenameList RobotFiles;
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x150 */ public GcCreatureRoleFilenameList[] WeirdBiomeFiles;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x300 */ public float[] LifeChance;
        [NMS(Size = 0x4, EnumType = typeof(GcCreatureRoleFrequencyModifier.CreatureRoleFrequencyModifierEnum))]
        /* 0x310 */ public float[] RoleFrequencyModifiers;
    }
}
