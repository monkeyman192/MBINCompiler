using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA95C7BD23973E843, NameHash = 0x5F135E)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A Image;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20A Title;
        [NMS(Index = 7)]
        /* 0x60 */ public VariableSizeString DebugText;
        [NMS(Index = 5)]
        /* 0x70 */ public List<GcMissionSequenceDetailMessagePoint> Points;
        [NMS(Index = 3)]
        /* 0x80 */ public NMSString0x10 TakeImageFromItemIcon;
        [NMS(Index = 4)]
        /* 0x90 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 6)]
        /* 0x94 */ public bool TakeDataFromSeason;
    }
}
