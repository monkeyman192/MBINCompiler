using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Alignment = 0x8, Size = 0x18, GUID = 0xF9EBAB99C51AB35F, NameHash = 0xDB0FD87A0597E5FD)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        public List<NMSString0x80> ReplicaComponentMask;
		public enum ReplicationRangeEnum { NotSet, Universal, System, Systemlocal, Planet, PlanetLocal, Space, SpaceStation, Nexus }
		public ReplicationRangeEnum ReplicationRange;
		public enum SpawnTypeEnum { Basic, Creature }
		public SpawnTypeEnum SpawnType;
    }
}
