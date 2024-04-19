using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8D71ACB4123A953, NameHash = 0x92F24A976CBF224B)]
    public class GcBaseBuildingPartStyleModel : NMSTemplate
    {
        /* 0x000 */ public TkModelResource Inactive;
        /* 0x084 */ public TkModelResource Model;
        /* 0x108 */ public GcBaseBuildingPartStyle Style;
    }
}
