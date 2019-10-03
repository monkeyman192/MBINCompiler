using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6971D929A87B9FEA, NameHash = 0xF848BA9A5DFC4197)]
    public class GcCreatureTypes : NMSTemplate
    {
        // 0x1F entries
		public enum CreatureTypeEnum { None, Bird, FlyingLizard, FlyingSnake, Butterfly, Beetle, Fish, Shark, Crab, Snake, Dino, Antelope, Rodent,
            Cat, Fiend, Drone, Quad, Walker, Predator, PlayerPredator, Prey, Passive, FishPredator, FishPrey, FiendFishSmall, FiendFishBig, Jellyfish,
            RockCreature, MiniFiend, Weird, Brainless
        }
		public CreatureTypeEnum CreatureType;
    }
}
