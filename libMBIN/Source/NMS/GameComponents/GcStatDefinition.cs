using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E22C381DC23B8C8, NameHash = 0xFC87DBA4)]
    public class GcStatDefinition : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public GcStatValueData DefaultValue;
        [NMS(Index = 2)]
        /* 0x1C */ public GcStatDisplayType DisplayType;
        [NMS(Index = 8)]
        /* 0x20 */ public int MissionMessageDecimals;
        [NMS(Index = 1)]
        /* 0x24 */ public GcStatTrackType TrackType;
        [NMS(Index = 0)]
        /* 0x28 */ public GcStatType Type;
        [NMS(Index = 7)]
        /* 0x2C */ public bool AllowRemoteRecord;
        [NMS(Index = 6)]
        /* 0x2D */ public bool IsProgression;
        [NMS(Index = 5)]
        /* 0x2E */ public bool TelemetryUpload;
    }
}
