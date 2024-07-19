using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7103CC9331BC5A57, NameHash = 0x5BC37A65, Alignment = 0x10)]
    public class GcMultiColouriseComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcColourisePalette> Palettes;
    }
}
