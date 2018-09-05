namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x98)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Misssion;
        public bool UseSeed;
        [NMS(Size = 0x80)]
        public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
