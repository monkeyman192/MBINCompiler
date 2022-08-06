using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBBF6699C968037A5, NameHash = 0x908C3E825994D6F)]
    public class GcCustomisationFreighterEngineEffect : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public NMSString0x10 LinkedTechID;
        /* 0x20 */ public NMSString0x10 LinkedSpecialID;
        /* 0x30 */ public NMSString0x20A Tip;
        /* 0x50 */ public TkModelResource EffectResource;
    }
}
