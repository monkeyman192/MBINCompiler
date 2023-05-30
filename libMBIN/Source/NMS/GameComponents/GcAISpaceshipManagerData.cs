using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcAISpaceshipMappingData[] FactionMapping;
    }
}
