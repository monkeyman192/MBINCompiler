using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EC5BB207DEE02EE, NameHash = 0xBDB2EAAD)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0 */ public float[] CivilianClassWeightings;
    }
}
