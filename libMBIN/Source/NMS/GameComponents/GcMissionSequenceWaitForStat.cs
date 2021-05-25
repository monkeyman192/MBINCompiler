using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x128, GUID = 0x2BEFBFF68BD985C8, NameHash = 0x197E91849165F7F4)]
    public class GcMissionSequenceWaitForStat : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Stat;
        [NMS(Size = 0x10)]
        /* 0x090 */ public string StatGroup;
        /* 0x0A0 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x0A4 */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}