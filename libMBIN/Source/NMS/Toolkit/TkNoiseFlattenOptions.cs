using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x7AC8009D9FC92522, NameHash = 0xB92478FDE531276E)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
		public enum FlatteningEnum { None, Natural, Artificial, AddResource }
		public FlatteningEnum Flattening;

		public enum WaterPlacementEnum { None, Underwater, UnderwaterOnly }
		public WaterPlacementEnum WaterPlacement;
    }
}
