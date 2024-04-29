using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5F7DD303A0A960A, NameHash = 0x9D50983DD366009C, Alignment = 0x10)]
    public class GcMultiColouriseComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcColourisePalette> Palettes;
    }
}
