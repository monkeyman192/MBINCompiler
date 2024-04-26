using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD959CE7DFB3C4B32, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public NMSString0x20A Description;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x20A Image;
        [NMS(Index = 0)]
        /* 0x040 */ public NMSString0x20A Title;
        [NMS(Index = 5)]
        /* 0x060 */ public List<GcMissionSequenceDetailMessagePoint> Points;
        [NMS(Index = 3)]
        /* 0x070 */ public NMSString0x10 TakeImageFromItemIcon;
        [NMS(Index = 4)]
        /* 0x080 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 7)]
        /* 0x084 */ public NMSString0x80 DebugText;
        [NMS(Index = 6)]
        /* 0x104 */ public bool TakeDataFromSeason;
    }
}
