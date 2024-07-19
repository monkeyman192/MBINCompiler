using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3402A2773D12E11, NameHash = 0xA4B8CB6A)]
    public class GcPerformanceGuard : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcEncounterComponentData Encounter;
        [NMS(Index = 0)]
        /* 0x18 */ public float Radius;
    }
}
