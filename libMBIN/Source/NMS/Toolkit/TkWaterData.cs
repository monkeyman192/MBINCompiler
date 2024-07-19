using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1E9BA4EE37B46B45, NameHash = 0xD4D0EA68)]
    public class TkWaterData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xD, EnumType = typeof(TkWaterCondition.WaterConditionEnum))]
        /* 0x000 */ public TkWaterConditionData[] WaterConditions;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(TkWaterRequirement.WaterRequirementEnum))]
        /* 0x2D8 */ public TkAllowedWaterConditions[] WaterConditionUsage;
        [NMS(Index = 0)]
        /* 0x318 */ public float MinimumWavelength;
    }
}
