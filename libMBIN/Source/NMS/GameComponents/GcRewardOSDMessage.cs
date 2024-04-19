using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12B81DB44F5724FF, NameHash = 0x53D72723F082671D)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        /* 0x00 */ public Colour MessageColour;
        /* 0x10 */ public NMSString0x20A Message;
        /* 0x30 */ public TkTextureResource Icon;
        /* 0xB4 */ public GcAudioWwiseEvents AudioEvent;
        /* 0xB8 */ public float Time;
        /* 0xBC */ public bool UseTimedMessage;
    }
}
