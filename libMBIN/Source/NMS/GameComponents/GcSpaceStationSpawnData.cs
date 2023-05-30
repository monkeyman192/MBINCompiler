using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSpaceStationSpawnData : NMSTemplate
    {
        public int SpawnMode;
        public string[] SpawnModeValues()
        {
            return new[] { "None", "UseSeed", "UseAltID" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;
        public GcSeed Seed;
        public NMSString0x100 AltId;
        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding118;
        public Vector4f SpawnPosition;
        public Vector4f SpawnFacing;
    }
}
