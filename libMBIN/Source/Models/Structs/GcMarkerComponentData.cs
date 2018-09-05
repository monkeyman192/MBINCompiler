namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcMarkerComponentData : NMSTemplate
    {
        /* 0x00 */ public GcGenericIconTypes GenericIconType;
        /* 0x04 */ public float Radius;
        /* 0x08 */ public int DisplayMode;
        public string[] DisplayModeValues()
        {
            return new[] { "Always", "SpaceOnly", "PlanetOnly" };
        }

        /* 0x0C */ public bool ShipScannable;

        [NMS(Size = 3, Ignore = true)]
        public byte[] PaddingD;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string CustomName;
    }
}
