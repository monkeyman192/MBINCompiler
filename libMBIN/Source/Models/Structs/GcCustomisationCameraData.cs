namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x34)]
    public class GcCustomisationCameraData : NMSTemplate
    {
        public int InteractionCameraIndex;
        [NMS(Size = 0x20)]
        public string InteracttionCameraFocusJoint;
        public float MinPitch;
        public float MaxPitch;
        public float MinYaw;
        public float MaxYaw;
    }
}
