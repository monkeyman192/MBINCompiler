using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2E229E8595D4D81, NameHash = 0x2137035790C4EDC0)]
    public class GcCustomisationBobbleHead : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 LinkedTechId;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource BobbleHead;
    }
}
