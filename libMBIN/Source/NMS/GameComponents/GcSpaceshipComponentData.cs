using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSpaceshipComponentData : NMSTemplate
    {
        public GcSpaceshipClasses ShipClass;
        public NMSString0x80 Cockpit;
        public float MaxHeadTurn;
        public float MaxHeadPitchUp;
        public float MaxHeadPitchDown;
        public int BaseHealth;
        public float FoVFixedDistance;
    }
}
