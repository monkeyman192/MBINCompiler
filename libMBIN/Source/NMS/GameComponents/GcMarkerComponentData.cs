using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE38AF240DDEF7C3, NameHash = 0x499B7E363F46B54F)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CustomName;
        /* 0x20 */ public GcRealityGameIcons CustomIcon;
        // size: 0x3
        public enum DisplayModeEnum : uint {
            Always,
            SpaceOnly,
            PlanetOnly,
        }
        /* 0x24 */ public DisplayModeEnum DisplayMode;
        /* 0x28 */ public GcGenericIconTypes Icon;
        /* 0x2C */ public float Radius;
        /* 0x30 */ public bool ShipScannable;
        /* 0x31 */ public bool UseCustomIcon;
    }
}
