using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74B8A7F3413A0905, NameHash = 0x76E42785)]
    public class GcMissionConditionGrabbingRecyclableOfType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcRecyclableType RequiredType;
    }
}
