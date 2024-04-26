using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CF16B949B560BF, NameHash = 0x9D50983DD366009C, Alignment = 0x10)]
    public class GcMultiColouriseComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcColourisePalette> Palettes;
    }
}
