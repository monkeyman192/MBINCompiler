using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x1CB1A34E16FAAC99, NameHash = 0xF848BA9A5DFC4197)]
    public class GcCreatureTypes : NMSTemplate
    {
        // 0x24 entries
		public enum CreatureTypeEnum {
            None, Bird, FlyingLizard, FlyingSnake, Butterfly, Beetle, Fish, Shark, Crab, Snake,
            Dino, Antelope, Rodent, Cat, Fiend, Drone, Quad, Walker, Predator, PlayerPredator,
            Prey, Passive, FishPredator, FishPrey, FiendFishSmall, FiendFishBig, Jellyfish, RockCreature, MiniFiend, Floater,
            Scuttler, Slug, MiniDrone, Weird, Brainless, Pet
        }
		public CreatureTypeEnum CreatureType;
    }
}