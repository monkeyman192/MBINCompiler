namespace MBINCompiler.Models.Structs
{
    public class GcSavedInteractionRaceData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 7)]
        public int[] SavedRaceIndicies; // unsure if this is float[] or not, code for this template is very strange
    }
}
