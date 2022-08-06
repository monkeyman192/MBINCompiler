using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCFE6B3996CFA666, NameHash = 0xDCBE648F7DED1A9F)]
    public class GcExpeditionHologramComponentData : NMSTemplate
    {
        public float HologramRotationSpeedDegPerSec;
        public float CaptainScale;
        public float FrigateScale;
        public Vector3f SpawnOffset;
    }
}
