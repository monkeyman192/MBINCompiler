using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0xF4171603FA4303CD, NameHash = 0x7A4371C33E264E2C)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        public NMSString0x10 MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}