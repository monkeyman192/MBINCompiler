using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FB80DD4F9879EAE, NameHash = 0xA0FEA9597B471B4A)]
    public class GcBiomeFileListOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBiomeFileListOption> FileOptions;
    }
}
