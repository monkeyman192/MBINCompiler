using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x988E76D34C9C8D7, NameHash = 0xA0FEA9597B471B4A)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBiomeFileListOption> FileOptions;
    }
}
