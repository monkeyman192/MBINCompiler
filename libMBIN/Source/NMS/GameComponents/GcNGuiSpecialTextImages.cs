using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F3D3ECB111BCEAB, NameHash = 0x4A2BA9B8)]
    public class GcNGuiSpecialTextImages : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextImageData> SpecialImages;
    }
}
