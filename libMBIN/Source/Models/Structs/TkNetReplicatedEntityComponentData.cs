using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class TkNetReplicatedEntityComponentData : NMSTemplate
    {
        public List<NMSString0x80> ReplicaComponentMask;
        public int ReplicationRange;
        public string[] ReplicationRangeValues()
        {
            return new[] { "Universal", "System", "Planet", "Space", "PlanetLocal" };
        }
        public int SpawnType;
        public string[] SpawnTypeValues()
        {
            return new[] { "Basic", "Creature"};
        }
    }
}
