using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x70C9B36E1F569537, NameHash = 0x8B5246BFCB875531)]
    public class TkNGuiLayoutList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkNGuiLayoutListData> Layouts;
    }
}
