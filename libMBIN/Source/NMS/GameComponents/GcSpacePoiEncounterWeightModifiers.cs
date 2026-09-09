using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90E261C27B7C223E, NameHash = 0x57B8058C)]
    public class GcSpacePoiEncounterWeightModifiers : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcSpacePoiEncounterType.SpacePoiEncounterTypeEnum))]
        /* 0x0 */ public int[] Modifiers;
    }
}
