using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x698AFD51E3068839, NameHash = 0x24E4352E3DDE4F22)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        /* 0x00 */ public List<GcPlayerEmote> Emotes;
    }
}
