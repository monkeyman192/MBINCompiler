namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1C0)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        public GcNPCAnimationSetData StandingAnimatons;
        public GcNPCAnimationSetData StandingIPadAnimatons;
        public GcNPCAnimationSetData SittingAnimatons;
        public GcNPCAnimationSetData SittingIPadAnimatons;
    }
}
