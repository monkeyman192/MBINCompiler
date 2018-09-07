namespace libMBIN.Models.Structs
{
    public class TkNoiseFlattenOptions : NMSTemplate
    {
		public enum FlatteningEnum { None, Natural, Artificial, AddResource }
		public FlatteningEnum Flattening;

		public enum WaterPlacementEnum { None, Underwater }
		public WaterPlacementEnum WaterPlacement;
    }
}
