namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x78)]
    public class GcPlayerCharacterState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Locomotion0H;
        [NMS(Size = 0x10)]
        public string Locomotion1H;
        [NMS(Size = 0x10)]
        public string Locomotion2H;
        [NMS(Size = 0x10)]
        public string AimTree1HPitch;
        [NMS(Size = 0x10)]
        public string AimTree1HYaw;
        [NMS(Size = 0x10)]
        public string AimTree2HPitch;
        [NMS(Size = 0x10)]
        public string AimTree2HYaw;
        public bool KeepHeadForward;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
