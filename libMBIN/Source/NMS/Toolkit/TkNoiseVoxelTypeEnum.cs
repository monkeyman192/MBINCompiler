using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseVoxelTypeEnum : NMSTemplate
    {
        public int NoiseVoxelType;
        public string[] NoiseVoxelTypeValues()
        {
            return new[] { "Base", "Rock", "Mountain", "Sand", "Cave", "Substance_1", "Substance_2", "Substance_3" };
        }
    }
}
