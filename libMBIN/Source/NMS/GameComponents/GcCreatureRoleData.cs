using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureRoleData : NMSTemplate
    {
        public GcSeed Seed;
        public GcCreatureTypes CreatureType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;

        public NMSString0x10 CreatureId;
        public GcCreatureRoleDescription Description;
        public GcCreatureInfo Info;
        public GcTerrainTileType TileType;
        public int Diet;
        public string[] DietValues()
        {
            return new[] { "Carnivore", "Omnivore", "Herbivore" };
        }
        public float BaseScale;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding48C;
    }
}
