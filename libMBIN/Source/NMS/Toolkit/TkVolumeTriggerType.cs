using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x700B1442D965A7F5, NameHash = 0xA4F2D5595864317D)]
    public class TkVolumeTriggerType : NMSTemplate
    {
        // 0xF entries
		public enum VolumeTriggerTypeEnum { Open, GenericInterior, GenericGlassInterior, Corridor, SmallRoom, LargeRoom, OpenCovered, HazardProtection,
                                            FieldBoundary, Custom_Biodome, Portal, VehicleBoost, NexusPlaza, NexusCommunityHub, NexusHangar }
		public VolumeTriggerTypeEnum VolumeTriggerType;
    }
}
