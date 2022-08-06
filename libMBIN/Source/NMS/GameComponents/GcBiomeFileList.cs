using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7B20F162CA4FB38, NameHash = 0x369AF9F4E4E055D0)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        /* 0x100 */ public List<GcBiomeType> ValidStartPlanetBiome;
        /* 0x110 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        /* 0x120 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
    }
}
