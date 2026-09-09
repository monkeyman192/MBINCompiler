using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x256628203416E2B6, NameHash = 0xFC2A8A7F)]
    public class GcSpacePoiEncounterWeights : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcSpacePoiEncounterType.SpacePoiEncounterTypeEnum))]
        /* 0x0 */ public int[] Weights;
    }
}
