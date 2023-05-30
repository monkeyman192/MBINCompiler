using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseFlattenOptions : NMSTemplate
    {
        public int Flattening;
        public string[] FlatteningValues()
        {
            return new[] { "None", "Natural", "Artificial", "AddResource" };
        }

        public int WaterPlacement;
        public string[] WaterPlacementValues()
        {
            return new[] { "None", "Underwater", "AboveWater" };
        }
    }
}
