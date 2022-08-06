using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CDF915FBA8D3FEF, NameHash = 0x1FD33D08A7082C22)]
    public class GcSpaceStationSpawnData : NMSTemplate
    {
		public enum SpawnModeEnum { None, UseSeed, UseAltID }
		public SpawnModeEnum SpawnMode;
        public GcSeed Seed;
        public NMSString0x100 AltId;
        public Vector3f SpawnPosition;
        public Vector3f SpawnFacing;
    }
}