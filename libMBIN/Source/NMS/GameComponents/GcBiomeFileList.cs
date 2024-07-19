using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DC849CF51AD2756, NameHash = 0xD7B3E587)]
    public class GcBiomeFileList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcBiomeFileListOptions[] BiomeFiles;
        [NMS(Index = 2)]
        /* 0x100 */ public List<GcExternalObjectListOptions> CommonExternalObjectLists;
        [NMS(Index = 3)]
        /* 0x110 */ public List<GcExternalObjectFileList> OptionalExternalObjectLists;
        [NMS(Index = 1)]
        /* 0x120 */ public List<GcBiomeType> ValidStartPlanetBiome;
    }
}
