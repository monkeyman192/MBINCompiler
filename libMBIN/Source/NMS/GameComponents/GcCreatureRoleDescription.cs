using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0xE33219262B98E806, NameHash = 0xA1B4C2EA26DFEA74)]
    public class GcCreatureRoleDescription : NMSTemplate
    {
        public GcCreatureRoles CreatureRole;
        public GcCreatureTypes CreatureType;

        [NMS(Size = 0x10)]
        public string ForceID;

        public float MinGroupScale;
        public float MaxGroupScale;
        public int MinGroupSize;
        public int MaxGroupSize;
        public float GroupsPerSquareKm;
        public float FractionActiveInDay;
        public float FractionActiveInNight;
        public float ProbabilityOfBeingEnabled;
        public float IncreasedSpawnDistance;
    
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding3C;
        [NMS(Size = 0x20)]
        public string Filter;
    }
}
