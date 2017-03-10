namespace MBINCompiler.Models.Structs
{
    public class TkVolumeTriggerType : NMSTemplate
    {
        public int VolumeTriggerType;
        public string[] VolumeTriggerTypeValues()
        {
            return new[] { "Open", "GenericInterior", "Corridor", "SmallRoom", "LargeRoom", "OpenCovered" };
        }
    }
}
