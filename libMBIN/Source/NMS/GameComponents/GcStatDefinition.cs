using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7EB0E264D2085A6, NameHash = 0xC70BF0DB96EC45A3)]
    public class GcStatDefinition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcStatValueData DefaultValue;
        /* 0x1C */ public GcStatDisplayType DisplayType;
        /* 0x20 */ public int MissionMessageDecimals;
        /* 0x24 */ public GcStatTrackType TrackType;
        /* 0x28 */ public GcStatType Type;
        /* 0x2C */ public bool IsProgression;
        /* 0x2D */ public bool TelemetryUpload;
    }
}
