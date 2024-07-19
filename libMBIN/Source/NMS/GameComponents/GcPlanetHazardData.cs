using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADF304D0B4BA05B9, NameHash = 0x34800A5C)]
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Index = 3, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x00 */ public float[] LifeSupportDrain;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x14 */ public float[] Radiation;
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x28 */ public float[] Temperature;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcHazardValueTypes.HazardValueEnum))]
        /* 0x3C */ public float[] Toxicity;
    }
}
