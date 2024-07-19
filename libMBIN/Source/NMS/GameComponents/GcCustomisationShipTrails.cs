using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C8D0A5A596EB91C, NameHash = 0x67C3C3C4)]
    public class GcCustomisationShipTrails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource Trails;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 LinkedTechID;
    }
}
