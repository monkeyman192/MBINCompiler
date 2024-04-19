using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x975312EAEE5209F4, NameHash = 0x987EE8E8873AED6B)]
    public class GcLeveledStatData : NMSTemplate
    {
        [NMS(Size = 0xB)]
        /* 0x000 */ public GcStatLevelData[] StatLevels;
        /* 0x580 */ public NMSString0x20A NotifyMessage;
        /* 0x5A0 */ public NMSString0x20A NotifyMessageSingular;
        /* 0x5C0 */ public NMSString0x20A StatTitle;
        /* 0x5E0 */ public NMSString0x10 StatId;
        /* 0x5F0 */ public TkTextureResource Icon;
        // size: 0x3
        public enum StatMessageTypeEnum : uint {
            Full,
            Quick,
            Silent,
        }
        /* 0x674 */ public StatMessageTypeEnum StatMessageType;
        /* 0x678 */ public bool ShowInTerminal;
        /* 0x679 */ public bool ShowStatLevel;
        /* 0x67A */ public bool TelemetryUpload;
        /* 0x67B */ public bool UseRankNotStats;
    }
}
