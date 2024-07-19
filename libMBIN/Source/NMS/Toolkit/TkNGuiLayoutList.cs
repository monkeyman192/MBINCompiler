using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD5217F7F60F122F3, NameHash = 0x9A5051F7)]
    public class TkNGuiLayoutList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkNGuiLayoutListData> Layouts;
    }
}
