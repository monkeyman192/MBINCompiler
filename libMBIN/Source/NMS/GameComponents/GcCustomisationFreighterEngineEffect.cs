using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x299080E945E25516, NameHash = 0x908C3E825994D6F)]
    public class GcCustomisationFreighterEngineEffect : NMSTemplate
    {
        /* 0x00 */ public Colour GlowColour;
        /* 0x10 */ public NMSString0x20A Tip;
        /* 0x30 */ public NMSString0x10 LinkedSpecialID;
        /* 0x40 */ public NMSString0x10 LinkedTechID;
        /* 0x50 */ public NMSString0x10 Name;
        /* 0x60 */ public TkModelResource EffectResource;
    }
}
