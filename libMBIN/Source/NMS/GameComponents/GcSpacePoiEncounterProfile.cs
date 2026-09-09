using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB02541AD11EACA43, NameHash = 0x26B310CD)]
    public class GcSpacePoiEncounterProfile : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSpacePoiEncounterSystemWeights AbandonedSystems;
        [NMS(Index = 2)]
        /* 0xE8 */ public GcSpacePoiEncounterSystemWeights Default;
    }
}
