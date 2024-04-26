using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x975312EAEE5209F4, NameHash = 0x987EE8E8873AED6B)]
    public class GcLeveledStatData : NMSTemplate
    {
        [NMS(Index = 8, Size = 0xB)]
        /* 0x000 */ public GcStatLevelData[] StatLevels;
        [NMS(Index = 3)]
        /* 0x580 */ public NMSString0x20A NotifyMessage;
        [NMS(Index = 4)]
        /* 0x5A0 */ public NMSString0x20A NotifyMessageSingular;
        [NMS(Index = 1)]
        /* 0x5C0 */ public NMSString0x20A StatTitle;
        [NMS(Index = 0)]
        /* 0x5E0 */ public NMSString0x10 StatId;
        [NMS(Index = 7)]
        /* 0x5F0 */ public TkTextureResource Icon;
        // size: 0x3
        public enum StatMessageTypeEnum : uint {
            Full,
            Quick,
            Silent,
        }
        [NMS(Index = 2)]
        /* 0x674 */ public StatMessageTypeEnum StatMessageType;
        [NMS(Index = 5)]
        /* 0x678 */ public bool ShowInTerminal;
        [NMS(Index = 6)]
        /* 0x679 */ public bool ShowStatLevel;
        [NMS(Index = 10)]
        /* 0x67A */ public bool TelemetryUpload;
        [NMS(Index = 9)]
        /* 0x67B */ public bool UseRankNotStats;
    }
}
