using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x683915DA7AC592B1, NameHash = 0x7714ED08)]
    public class GcMarkerComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A CustomName;
        [NMS(Index = 6)]
        /* 0x20 */ public GcRealityGameIcons CustomIcon;
        // size: 0x3
        public enum DisplayModeEnum : uint {
            Always,
            SpaceOnly,
            PlanetOnly,
        }
        [NMS(Index = 2)]
        /* 0x24 */ public DisplayModeEnum DisplayMode;
        [NMS(Index = 0)]
        /* 0x28 */ public GcGenericIconTypes Icon;
        [NMS(Index = 1)]
        /* 0x2C */ public float Radius;
        [NMS(Index = 3)]
        /* 0x30 */ public bool ShipScannable;
        [NMS(Index = 5)]
        /* 0x31 */ public bool UseCustomIcon;
    }
}
