using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureRoles : NMSTemplate
    {
        public int CreatureRole;
        public string[] CreatureRoleValues()
        {
            return new[]
            {
                "None", "Predator", "PlayerPredator", "Prey", "Passive", "Bird", "FishPrey", "FishPredator", "Butterfly", "Robot"
            };
        }
    }
}
