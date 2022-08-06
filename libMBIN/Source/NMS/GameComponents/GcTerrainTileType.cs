using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFB195227CDEA6E2, NameHash = 0x6247F06C43E3ADDD)]
    public class GcTerrainTileType : NMSTemplate
    {
        // size: 0x9
		public enum TileTypeEnum { Air, Base, Rock, Mountain, Underwater, Cave, Dirt, Liquid, Substance }
		public TileTypeEnum TileType;
    }
}