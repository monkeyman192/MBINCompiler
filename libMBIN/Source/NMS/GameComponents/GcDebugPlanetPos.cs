using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xC1DB426601356D64, NameHash = 0x670C19192705F25A)]
    public class GcDebugPlanetPos : NMSTemplate
    {
        public Vector3f Position;
        public bool OverridePosition;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] EndPadding;
    }
}
