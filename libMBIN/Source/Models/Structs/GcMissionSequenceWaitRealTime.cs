namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x108)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public ulong Time;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
