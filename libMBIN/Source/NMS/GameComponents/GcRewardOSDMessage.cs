using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12B81DB44F5724FF, NameHash = 0x53D72723F082671D)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour MessageColour;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x20A Message;
        [NMS(Index = 3)]
        /* 0x30 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0xB4 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0xB8 */ public float Time;
        [NMS(Index = 5)]
        /* 0xBC */ public bool UseTimedMessage;
    }
}
