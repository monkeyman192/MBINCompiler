using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4876EEC8370DF47, NameHash = 0x8C8D94961F3707E0)]
    public class GcWeightedColourId : NMSTemplate
    {
        /* 0x00 */ public float RelativeProbability;
        /* 0x08 */ public NMSString0x20A Palette;
        /* 0x28 */ public NMSString0x20A DecorationPalette;
    }
}
