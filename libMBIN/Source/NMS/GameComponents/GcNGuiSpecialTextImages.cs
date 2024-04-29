using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x837F40DA09AC56F6, NameHash = 0x4A7B04831F4234B1)]
    public class GcNGuiSpecialTextImages : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextImageData> SpecialImages;
    }
}
