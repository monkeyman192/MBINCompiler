using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0CF8A6E4F982340, NameHash = 0x2ED2EBC3)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Colour MessageColour;
        [NMS(Index = 4)]
        /* 0x10 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x28 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x38 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 0)]
        /* 0x3C */ public float Time;
        [NMS(Index = 2)]
        /* 0x40 */ public bool RandomiseMessage;
        [NMS(Index = 7)]
        /* 0x41 */ public bool UseFancyMessage;
        [NMS(Index = 8)]
        /* 0x42 */ public bool UseSpookMessage;
        [NMS(Index = 6)]
        /* 0x43 */ public bool UseTimedMessage;
    }
}
