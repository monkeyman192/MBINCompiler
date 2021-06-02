using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xA385A1C7FA49076F, NameHash = 0x39BE669FF8F8CD9)]
    public class GcSolarSystemLocator : NMSTemplate
    {
        public NMSString0x20 Name;
        public GcSolarSystemLocatorTypes LocatorType;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding24;

        public Vector4f Position;
        public Vector4f Direction;
        public float Radius;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding54;
    }
}