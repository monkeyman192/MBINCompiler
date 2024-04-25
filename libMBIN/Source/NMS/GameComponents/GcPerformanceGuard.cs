using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A31E46440F4A5A5, NameHash = 0xC88FD2BBB93553F9)]
    public class GcPerformanceGuard : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcEncounterComponentData Encounter;
        [NMS(Index = 0)]
        /* 0x18 */ public float Radius;
    }
}
