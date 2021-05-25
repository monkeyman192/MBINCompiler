using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, GUID = 0x9FFA9D35267DC57E, NameHash = 0xA4F2D5595864317D)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // size: 0x10
		public enum VolumeTriggerTypeEnum {
            Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom, OpenCovered, HazardProtection, FieldBoundary, Custom_Biodome,
            Portal, VehicleBoost, NexusPlaza, NexusCommunityHub, NexusHangar, RaceObstacle
        }
		public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}