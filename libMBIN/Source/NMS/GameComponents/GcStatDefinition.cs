using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x5800701514EE47D8, NameHash = 0xC70BF0DB96EC45A3)]
    public class GcStatDefinition : NMSTemplate
    {
        /* 0x00 */ public GcStatType Type;
        /* 0x04 */ public GcStatTrackType TrackType;
        /* 0x08 */ public GcStatDisplayType DisplayType;
        /* 0x0C */ public GcStatValueData DefaultValue;
        /* 0x18 */ public NMSString0x10 Id;
        /* 0x28 */ public bool TelemetryUpload;
        /* 0x29 */ public bool IsProgression;
        /* 0x2C */ public int MissionMessageDecimals;
    }
}
