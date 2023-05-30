using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureData : NMSTemplate
    {
        public NMSString0x10 Id;

        public NMSString0x20 Genus;

        public GcCreatureTypes CreatureType;

        public int MoveArea;
        public string[] MoveAreaValues()
        {
            return new[] { "Ground", "Water", "Air", "Space" };
        }

        public float MinScale;
        public float MaxScale;
        public GcRarity Rarity;

        public List<NMSTemplate> Data;
    }
}
