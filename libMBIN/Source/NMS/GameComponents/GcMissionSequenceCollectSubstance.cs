using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, Alignment = 0x8, GUID = 0xFC48D034E52D1F1A, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x084 */ public GcSubstanceTableEnum Substance;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        /* 0x090 */ public bool WaitForSelected;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x091 */ public byte[] Padding91;
        [NMS(Size = 0x10)]
        /* 0x098 */ public string ForBuild;
        [NMS(Size = 0x10)]
        /* 0x0A8 */ public string ForRepair;
        /* 0x0B8 */ public bool FromNow;
        [NMS(Size = 0x80)]
        /* 0x0B9 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x139 */ public byte[] EndPadding;
    }
}
