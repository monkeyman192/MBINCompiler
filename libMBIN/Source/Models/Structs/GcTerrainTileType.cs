namespace libMBIN.Models.Structs
{
    public class GcTerrainTileType : NMSTemplate
    {

		public enum TileTypeEnum { Air, Base, Rock, Mountain, Underwater, Cave, Dirt, Liquid, Substance }
		public TileTypeEnum TileType;
    }
}
