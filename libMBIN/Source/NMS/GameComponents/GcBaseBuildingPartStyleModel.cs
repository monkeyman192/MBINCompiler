using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BC442372640ABCD, NameHash = 0x80402E)]
    public class GcBaseBuildingPartStyleModel : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkModelResource Inactive;
        [NMS(Index = 1)]
        /* 0x20 */ public TkModelResource Model;
        [NMS(Index = 0)]
        /* 0x40 */ public GcBaseBuildingPartStyle Style;
    }
}
