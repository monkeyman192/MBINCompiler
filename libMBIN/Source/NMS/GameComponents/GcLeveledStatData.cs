using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB95AFE708F7072E, NameHash = 0x7D338136)]
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
        [NMS(Index = 7)]
        /* 0x5E0 */ public TkTextureResource Icon;
        [NMS(Index = 0)]
        /* 0x5F8 */ public NMSString0x10 StatId;
        // size: 0x3
        public enum StatMessageTypeEnum : uint {
            Full,
            Quick,
            Silent,
        }
        [NMS(Index = 2)]
        /* 0x608 */ public StatMessageTypeEnum StatMessageType;
        [NMS(Index = 5)]
        /* 0x60C */ public bool ShowInTerminal;
        [NMS(Index = 6)]
        /* 0x60D */ public bool ShowStatLevel;
        [NMS(Index = 10)]
        /* 0x60E */ public bool TelemetryUpload;
        [NMS(Index = 9)]
        /* 0x60F */ public bool UseRankNotStats;
    }
}
