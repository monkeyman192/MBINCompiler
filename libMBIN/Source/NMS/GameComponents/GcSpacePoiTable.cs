using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2F70E1C4426EE61, NameHash = 0xCD8447DC)]
    public class GcSpacePoiTable : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcSpacePoiEncounterProfile> EncounterProfiles;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcSpacePoiGenerationData> GenerationData;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcSpacePoiTableItem> Items;
        [NMS(Index = 2)]
        /* 0x30 */ public List<GcSpacePoiEncounterItem> RandomEncounters;
        [NMS(Index = 3)]
        /* 0x40 */ public List<GcSpacePoiEncounterItem> SpecialEncounters;
    }
}
