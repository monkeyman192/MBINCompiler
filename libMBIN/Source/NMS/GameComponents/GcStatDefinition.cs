using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7EB0E264D2085A6, NameHash = 0xC70BF0DB96EC45A3)]
    public class GcStatDefinition : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x10 */ public GcStatValueData DefaultValue;
        [NMS(Index = 2)]
        /* 0x1C */ public GcStatDisplayType DisplayType;
        [NMS(Index = 7)]
        /* 0x20 */ public int MissionMessageDecimals;
        [NMS(Index = 1)]
        /* 0x24 */ public GcStatTrackType TrackType;
        [NMS(Index = 0)]
        /* 0x28 */ public GcStatType Type;
        [NMS(Index = 6)]
        /* 0x2C */ public bool IsProgression;
        [NMS(Index = 5)]
        /* 0x2D */ public bool TelemetryUpload;
    }
}
