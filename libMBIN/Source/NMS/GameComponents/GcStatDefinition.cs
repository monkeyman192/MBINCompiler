using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xB3573221C8BAA4B, NameHash = 0xC70BF0DB96EC45A3)]
    public class GcStatDefinition : NMSTemplate
    {
        /* 0x00 */ public GcStatType Type;
        /* 0x04 */ public GcStatTrackType TrackType;
        /* 0x08 */ public GcStatDisplayType DisplayType;
        /* 0x0C */  public GcStatValueData DefaultValue;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string Id;
        /* 0x28 */ public bool TelemetryUpload;
        /* 0x29 */ public bool IsProgression;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x2A */ public byte[] EndPadding;
    }
}
