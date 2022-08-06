using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA385A1C7FA49076F, NameHash = 0x39BE669FF8F8CD9)]
    public class GcSolarSystemLocator : NMSTemplate
    {
        public NMSString0x20 Name;
        public GcSolarSystemLocatorTypes LocatorType;

        public Vector3f Position;
        public Vector3f Direction;
        public float Radius;
    }
}