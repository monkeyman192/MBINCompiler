using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD959CE7DFB3C4B32, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Description;
        /* 0x020 */ public NMSString0x20A Image;
        /* 0x040 */ public NMSString0x20A Title;
        /* 0x060 */ public List<GcMissionSequenceDetailMessagePoint> Points;
        /* 0x070 */ public NMSString0x10 TakeImageFromItemIcon;
        /* 0x080 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x084 */ public NMSString0x80 DebugText;
        /* 0x104 */ public bool TakeDataFromSeason;
    }
}
