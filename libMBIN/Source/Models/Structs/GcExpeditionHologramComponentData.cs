namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcExpeditionHologramComponentData : NMSTemplate
    {
        public float HologramRotationSpeedDegPerSec;
        public float CaptainScale;
        public float FrigateScale;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingC;
        public Vector4f SpawnOffset;
    }
}
