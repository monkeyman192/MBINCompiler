using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0xA280B47972861D12, NameHash = 0x499B7E363F46B54F)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes Icon;
        /* 0x04 */ public float Radius;
		public enum DisplayModeEnum { Always, SpaceOnly, PlanetOnly }
		/* 0x08 */ public DisplayModeEnum DisplayMode;
        /* 0x0C */ public bool ShipScannable;
        [NMS(Size = 3, Ignore = true)]
        /* 0x0D */ public byte[] PaddingD;
        /* 0x10 */ public NMSString0x20 CustomName;
        /* 0x30 */ public bool UseCustomIcon;
        /* 0x34 */ public GcRealityGameIcons CustomIcon;
    }
}
