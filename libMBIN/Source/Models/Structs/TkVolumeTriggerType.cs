namespace libMBIN.Models.Structs
{
    public class TkVolumeTriggerType : NMSTemplate
    {
		public enum VolumeTriggerTypeEnum { Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom, OpenCovered, HazardProtection, FieldBoundary, Custom_Biodome, Portal, VehicleBoost }
		public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
