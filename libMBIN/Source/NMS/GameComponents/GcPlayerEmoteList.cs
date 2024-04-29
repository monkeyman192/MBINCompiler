using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE8C8A9057A395B0, NameHash = 0x24E4352E3DDE4F22)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlayerEmote> Emotes;
    }
}
