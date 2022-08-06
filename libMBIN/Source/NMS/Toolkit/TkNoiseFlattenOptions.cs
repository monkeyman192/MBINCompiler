using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0xF9F37CB6A1E27E76, NameHash = 0xB92478FDE531276E)]
    public class TkNoiseFlattenOptions : NMSTemplate
    {
		public enum FlatteningEnum { None, Flatten, TerrainEdits }
		public FlatteningEnum Flattening;

		public enum WaterPlacementEnum { None, OnWater, Underwater, UnderwaterOnly }
		public WaterPlacementEnum WaterPlacement;
    }
}