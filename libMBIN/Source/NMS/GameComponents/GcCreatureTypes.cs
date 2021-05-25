using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x13214D86770F9247, NameHash = 0xF848BA9A5DFC4197)]
    public class GcCreatureTypes : NMSTemplate
    {
        // size: 0x2D
		public enum CreatureTypeEnum {
            None, Bird, FlyingLizard, FlyingSnake, Butterfly, FlyingBeetle, Beetle, Fish, Shark, Crab,
            Snake, Dino, Antelope, Rodent, Cat, Fiend, Drone, Quad, Walker, Predator,
            PlayerPredator, Prey, Passive, FishPredator, FishPrey, FiendFishSmall, FiendFishBig, Jellyfish, RockCreature, MiniFiend,
            Floater, Scuttler, Slug, MiniDrone, Weird, SeaSnake, SandWorm, ProtoRoller, ProtoFlyer, ProtoDigger,
            Plough, Digger, Drill, Brainless, Pet
        }
		public CreatureTypeEnum CreatureType;
    }
}