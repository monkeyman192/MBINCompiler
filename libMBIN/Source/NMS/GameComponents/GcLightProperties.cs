using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, Alignment = 0x10, GUID = 0x166006DB2573EE25, NameHash = 0x34A4221AAD19DAAE)]
    public class GcLightProperties : NMSTemplate {

        public Colour SunColour;
        public Colour LightColour;
        public Colour BounceColour;

    }

}
