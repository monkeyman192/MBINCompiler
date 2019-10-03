using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA385A1C7FA49076F, NameHash = 0x39BE669FF8F8CD9)]
    public class GcSolarSystemLocator : NMSTemplate // 0x60 bytes
    {
        [NMS(Size = 0x20)]
        public string Name;
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
