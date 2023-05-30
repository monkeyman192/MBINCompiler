using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTerrainTileType : NMSTemplate
    {
        public int TileType;

        public string[] TileTypeValues()
        {
            return new[]
            {
                "Air", "Base", "Rock", "Mountain", "Underwater", "Cave", "Dirt", "Liquid", "Substance"
            };
        }
    }
}
