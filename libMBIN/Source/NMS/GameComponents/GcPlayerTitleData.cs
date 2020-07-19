using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xB061F3164F22B45E, NameHash = 0xB6947F6F9E247CD4)]
    public class GcPlayerTitleData : NMSTemplate {
        /* 0x0 */ public List<GcPlayerTitle> Titles;
    }

}
