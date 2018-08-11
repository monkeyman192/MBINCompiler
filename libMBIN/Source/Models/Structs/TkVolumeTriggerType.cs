namespace libMBIN.Models.Structs
{
    public class TkVolumeTriggerType : NMSTemplate
    {
        public int VolumeTriggerType;
        public string[] VolumeTriggerTypeValues()
        {
            return new[] { "Open", "GenericInterior", "GenericGlassInterior", "Corridor", "SmallRoom", "LargeRoom", "OpenCovered",
                            "HazardProtection", "FieldBoundary", "Custom_Biodome", "Portal", "VehicleBoost" };
        }
    }
}
