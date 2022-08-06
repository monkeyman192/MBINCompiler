using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDEF24F60EAC6B496, NameHash = 0x79403B157D846B70)]
    public class GcAsteroidGeneratorRing : NMSTemplate
    {
        public GcAsteroidGeneratorAssignment Assignment;
        public float LowerRadius;
        public float UpperRadius;
        public float PushRadius;
        public int OffBalance;

        public Vector3f Rotation;
        public float USpread;
        public float PushAmount;
        public bool FlipPush;
    }
}