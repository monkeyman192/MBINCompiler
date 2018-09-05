namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcPlayerCharacterAnimationOverrideData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string AnimName;
        public GcPlayerCharacterIKOverrideData Data;
    }
}
