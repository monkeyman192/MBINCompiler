using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF38ACC62091E1E75, NameHash = 0xE2910F7CA28A0271)]
    public class GcTexturePrefetchData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Textures;
    }
}
