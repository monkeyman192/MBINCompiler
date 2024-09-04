using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95F601811F5A1DC6, NameHash = 0x2ED2EBC3)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Colour MessageColour;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x20A Message;
        [NMS(Index = 3)]
        /* 0x30 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x48 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0x4C */ public float Time;
        [NMS(Index = 5)]
        /* 0x50 */ public bool UseTimedMessage;
    }
}
