using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcRarity : NMSTemplate
    {
        public int Rarity;

        public string[] RarityValues()
        {
            return new[] { "Common", "Uncommon", "Rare", "Extraordinary", "None" };
        }
    }
}
