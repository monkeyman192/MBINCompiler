using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2C, GUID = 0x267CDC1694674427, NameHash = 0xF13F97A441A8794A)]
    public class GcAudioPulseDemo : NMSTemplate
    {
        public float MixRateSeconds;
        public Vector2f Planet;
        public Vector2f Space;
        public Vector2f SpaceStation;
        public Vector2f InWarp;
        public Vector2f Wanted;
    }
}
