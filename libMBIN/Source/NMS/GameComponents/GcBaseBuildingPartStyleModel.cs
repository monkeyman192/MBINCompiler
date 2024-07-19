using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB7C9FA949B4CE23, NameHash = 0x80402E)]
    public class GcBaseBuildingPartStyleModel : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkModelResource Inactive;
        [NMS(Index = 1)]
        /* 0x18 */ public TkModelResource Model;
        [NMS(Index = 0)]
        /* 0x30 */ public GcBaseBuildingPartStyle Style;
    }
}
