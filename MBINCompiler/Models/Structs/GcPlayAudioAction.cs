namespace MBINCompiler.Models.Structs
{
    public class GcPlayAudioAction : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Sound;
        public bool UseOcclusion;
        public float OcclusionRadius;
    }
}
