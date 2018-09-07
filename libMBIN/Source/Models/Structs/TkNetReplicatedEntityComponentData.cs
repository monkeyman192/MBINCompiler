using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        public List<NMSString0x80> ReplicaComponentMask;
		public enum ReplicationRangeEnum { Universal, System, Planet, Space, PlanetLocal }
		public ReplicationRangeEnum ReplicationRange;
		public enum SpawnTypeEnum { Basic, Creature }
		public SpawnTypeEnum SpawnType;
    }
}
