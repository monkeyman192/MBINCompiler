using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3186E3979A3468C6, NameHash = 0xAF70C2375D409B6F)]
    public class GcPlayerEffectsComponentData : NMSTemplate
    {
        public float VehicleInOutTime;
        public float VehicleInOutEffectDelay;
        public float VehicleInOutDissolveDelay;
    }
}