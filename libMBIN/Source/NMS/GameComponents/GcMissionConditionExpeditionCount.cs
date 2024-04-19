using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23379BA5EFBE3535, NameHash = 0xA4E47B76AADB4816)]
    public class GcMissionConditionExpeditionCount : NMSTemplate
    {
        /* 0x0 */ public int ExpeditionCount;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool ActiveExpeditionsCountAsFueled;
        /* 0x9 */ public bool OnlyCountAwaitingDebrief;
        /* 0xA */ public bool OnlyCountIfActive;
        /* 0xB */ public bool OnlyCountIfActiveWithRemainingEvents;
        /* 0xC */ public bool OnlyCountIfFueled;
    }
}
