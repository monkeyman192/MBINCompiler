using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8AC30FB0591F727, NameHash = 0xA2B1571E48DBF03D)]
    public class GcDialogClearanceTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcDialogClearanceInfo> Table;
    }
}
