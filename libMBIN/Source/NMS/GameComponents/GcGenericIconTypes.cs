using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcGenericIconTypes : NMSTemplate
    {
        public int GenericIconType;
        public string[] GenericIconTypeValues()
        {
            return new[] { "None", "Interaction", "SpaceStation", "SpaceAnomaly", "SpaceAtlas" };
        }
    }
}
