using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcExternalObjectListOptions : NMSTemplate // Size: 0x220
    {
        public NMSString0x10 Name;
        public float Probability;
        public GcTerrainTileType TileType;
        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        public NMSString0x80[] Options;
        public bool AllowLimiting;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding;
    }
}
