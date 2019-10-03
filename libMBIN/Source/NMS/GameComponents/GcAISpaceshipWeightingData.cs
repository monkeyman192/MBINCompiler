using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0xB164EA8EF150DFDC, NameHash = 0xD66342935A1B2735)]
    public class GcAISpaceshipWeightingData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        public float[] CivilianClassWeightings;
    }
}
