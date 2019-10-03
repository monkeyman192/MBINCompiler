using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4A07C0F132712212, NameHash = 0x840B4D8139B48954)]
    public class GcBirdData : NMSTemplate		// size: 0x90
    {
        public float FlapSpeedMax;
        public float FlapSpeedMin;
        public float FlapSpeed;
        public float FlapAccel;

        [NMS(Size = 0x80)]
        public string CircleAttractor;
    }
}
