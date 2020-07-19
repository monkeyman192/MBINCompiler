using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC0, Alignment = 0x10, GUID = 0xB5CFC6D77B061A1A, NameHash = 0x53D72723F082671D)]
    public class GcRewardOSDMessage : NMSTemplate
    {
        /* 0x00 */ public float Time;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x08 */ public string Message;
        /* 0x28 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x2C */ public TkTextureResource Icon;
        /* 0xB0 */ public Colour MessageColour;
    }
}
