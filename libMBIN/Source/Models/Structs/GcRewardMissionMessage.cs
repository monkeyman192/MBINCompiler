namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Endpadding;
    }
}
