using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureTypes : NMSTemplate
    {
        public int CreatureType;
        public string[] CreatureTypeValues()
        {
            return new[]
            {
                "None", "Bird", "FlyingLizard", "FlyingSnake", "Butterfly", "Beetle", "Fish", "Shark",
                "Crab", "Snake", "Dino", "Antelope", "Rodent", "Cat", "Drone", "Quad",
                "Walker", "Predator", "PlayerPredator", "Prey", "Passive", "Brainless"
            };
        }
    }
}
