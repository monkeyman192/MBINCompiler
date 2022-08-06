using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDA10D58FC718E8E9, NameHash = 0xDB0FD87A0597E5FD)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        public List<NMSString0x80> ReplicaComponentMask;
		public enum ReplicationRangeEnum { NotSet, System, Systemlocal, Planet, PlanetLocal, Space, SpaceStation, Nexus }
		public ReplicationRangeEnum ReplicationRange;
		public enum SpawnTypeEnum { Basic, Creature }
		public SpawnTypeEnum SpawnType;
        public bool IgnoreComponents;
    }
}
