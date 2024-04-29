namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EE2C961C4F1E96, NameHash = 0x8C8D94961F3707E0)]
    public class GcWeightedColourId : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A DecorationPalette;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Palette;
        [NMS(Index = 0)]
        /* 0x40 */ public float RelativeProbability;
    }
}
