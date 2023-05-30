using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcMarkerComponentData : NMSTemplate
    {
        public GcGenericIconTypes GenericIconType;
        public float Radius;
        public int DisplayMode;
        public string[] DisplayModeValues()
        {
            return new[] { "Always", "SpaceOnly", "PlanetOnly" };
        }

        public bool ShipScannable;

        [NMS(Size = 3, Ignore = true)]
        public byte[] PaddingD;
    }
}
