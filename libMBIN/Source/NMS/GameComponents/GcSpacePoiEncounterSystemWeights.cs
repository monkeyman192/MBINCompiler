using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D31813C8C95793, NameHash = 0xB1D47686)]
    public class GcSpacePoiEncounterSystemWeights : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x00 */ public GcSpacePoiEncounterWeightModifiers[] ConflictModifiers;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x60 */ public GcSpacePoiEncounterWeightModifiers[] WealthModifiers;
        [NMS(Index = 0)]
        /* 0xC0 */ public GcSpacePoiEncounterWeights BaseWeights;
    }
}
