using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34CDA59FB3D4AFD7, NameHash = 0x235BD45A5DEBE0D8)]
    public class GcCustomisationShipTrails : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 LinkedTechID;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource Trails;
    }
}
