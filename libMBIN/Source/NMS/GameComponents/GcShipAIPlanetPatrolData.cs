using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x6093D382214F692D, NameHash = 0xB7FEFB0DFC120BF4)]
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        public NMSString0x10 Squad;

        public float PlayerOffset;
        public float PlayerFalloff;
        public float PathOffset;
        public float WaypointDistance;
        public float PathSpeed;
        public float AlongPathForce;
        public float ToPathForce;
        public float BrakeForce;
        public float AlignForce;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding34;
    }
}
