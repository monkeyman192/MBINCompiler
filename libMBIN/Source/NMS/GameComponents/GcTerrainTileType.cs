namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75811DA9180574C6, NameHash = 0x6247F06C43E3ADDD)]
    public class GcTerrainTileType : NMSTemplate
    {
        // size: 0x9
        public enum TileTypeEnum : uint {
            Air,
            Base,
            Rock,
            Mountain,
            Underwater,
            Cave,
            Dirt,
            Liquid,
            Substance,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TileTypeEnum TileType;
    }
}
