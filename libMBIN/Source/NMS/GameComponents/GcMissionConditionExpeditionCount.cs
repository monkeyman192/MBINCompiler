using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CFC21689C1B922C, NameHash = 0xA4E47B76AADB4816)]
    public class GcMissionConditionExpeditionCount : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int ExpeditionCount;
        [NMS(Index = 6)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 5)]
        /* 0x8 */ public bool ActiveExpeditionsCountAsFueled;
        [NMS(Index = 4)]
        /* 0x9 */ public bool OnlyCountAwaitingDebrief;
        [NMS(Index = 1)]
        /* 0xA */ public bool OnlyCountIfActive;
        [NMS(Index = 2)]
        /* 0xB */ public bool OnlyCountIfActiveWithRemainingEvents;
        [NMS(Index = 3)]
        /* 0xC */ public bool OnlyCountIfFueled;
    }
}
