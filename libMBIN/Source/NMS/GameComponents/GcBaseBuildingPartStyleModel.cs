using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A237BE9BB69EF74, NameHash = 0x92F24A976CBF224B)]
    public class GcBaseBuildingPartStyleModel : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkModelResource Inactive;
        [NMS(Index = 1)]
        /* 0x084 */ public TkModelResource Model;
        [NMS(Index = 0)]
        /* 0x108 */ public GcBaseBuildingPartStyle Style;
    }
}
