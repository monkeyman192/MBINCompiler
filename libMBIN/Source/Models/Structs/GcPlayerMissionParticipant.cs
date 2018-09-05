namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcPlayerMissionParticipant : NMSTemplate
    {
        public ulong UA;
        public GcSeed BuildingSeed;
        public GcPlayerMissionParticipantType ParticipantType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
