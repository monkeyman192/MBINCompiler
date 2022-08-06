using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E717D0E8E4C9F5F, NameHash = 0x84D6228673F661A6)]
    public class GcMissionSequenceCollectSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x88 */ public NMSString0x10 Substance;
        /* 0x98 */ public int AmountMin;
        /* 0x9C */ public int AmountMax;
        /* 0xA0 */ public bool WaitForSelected;
        /* 0xA8 */ public NMSString0x10 ForBuild;
        /* 0xB8 */ public NMSString0x10 ForRepair;
        /* 0xC8 */ public bool FromNow;
        /* 0xC9 */ public bool TakeAmountFromSeasonData;
        /* 0xCA */ public NMSString0x80 DebugText;
    }
}
