using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xCCFE6B3996CFA666, NameHash = 0xDCBE648F7DED1A9F)]
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
