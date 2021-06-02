using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0xC30E8192B2598E1A, NameHash = 0x7C82C5EBE3916386)]
    public class GcPlayAudioAction : NMSTemplate
    {
        public NMSString0x80 Sound;
        public bool UseOcclusion;
        public float OcclusionRadius;
    }
}
