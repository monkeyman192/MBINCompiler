using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureRoleDescription : NMSTemplate
    {
        public GcCreatureRoles CreatureRole;
        public GcCreatureTypes CreatureType;

        public NMSString0x10 ForceID;

        public float MinGroupScale;
        public float MaxGroupScale;
        public int MinGroupSize;
        public int MaxGroupSize;
        public float GroupsPerSquareKm;
        public float FractionActiveInDay;
        public float FractionActiveInNight;
        public float ProbabilityOfBeingEnabled;
        public float IncreasedSpawnDistance;
    
        [NMS(Ignore = true)]
        public int Padding;
    }
}
