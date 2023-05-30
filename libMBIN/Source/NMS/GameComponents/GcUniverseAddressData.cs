using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcUniverseAddressData : NMSTemplate // 0x18 bytes
    {
        public int RealityIndex;

        public GcGalacticAddressData GalacticAddress;
    }
}
