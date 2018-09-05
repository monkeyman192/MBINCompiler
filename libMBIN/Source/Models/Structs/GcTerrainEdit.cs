namespace libMBIN.Models.Structs
{
    public class GcTerrainEdit : NMSTemplate      // size: 0x8
    {
        public int Data;        // this is actually a byte, but mbincompiler can't deseriaise a single byte (would need to add it...)
        public int Position;
    }
}
