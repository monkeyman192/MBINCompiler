using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x2BDD94D83A0F028F, NameHash = 0x499B7E363F46B54F)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes Icon;
        /* 0x04 */ public float Radius;
		public enum DisplayModeEnum { Always, SpaceOnly, PlanetOnly }
		/* 0x08 */ public DisplayModeEnum DisplayMode;
        /* 0x0C */ public bool ShipScannable;
        [NMS(Size = 3, Ignore = true)]
        /* 0x0D */ public byte[] PaddingD;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string CustomName;
        /* 0x30 */ public bool UseCustomIcon;
        /* 0x34 */ public GcRealityGameIcons Customicon;
    }
}
