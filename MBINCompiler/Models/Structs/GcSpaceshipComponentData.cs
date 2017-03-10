namespace MBINCompiler.Models.Structs
{
    public class GcSpaceshipComponentData : NMSTemplate
    {
        public GcSpaceshipClasses ShipClass;
        [NMS(Size = 0x80)]
        public string Cockpit;
        public float MaxHeadTurn;
        public float MaxHeadPitchUp;
        public float MaxHeadPitchDown;
        public int BaseHealth;
        public float FoVFixedDistance;
        [NMS(Size = 0x80)]
        public string WheelModel;
    }
}
