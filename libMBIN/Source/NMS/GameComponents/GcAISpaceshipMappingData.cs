using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Size = 3)]
        public GcAISpaceshipInstanceData[] ClassMap;
    }
}
