using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B9E57A9C1B8A2CE, NameHash = 0xE8BD6D72)]
    public class GcMissionConditionGrabbingPackageOfType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcDeliverableType RequiredType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool TestForMissionSeed;
    }
}
