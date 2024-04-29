using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74FC7E4F2F7791, NameHash = 0x908C3E825994D6F)]
    public class GcCustomisationFreighterEngineEffect : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public Colour GlowColour;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x20A Tip;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 LinkedTechID;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Name;
        [NMS(Index = 4)]
        /* 0x60 */ public TkModelResource EffectResource;
    }
}
