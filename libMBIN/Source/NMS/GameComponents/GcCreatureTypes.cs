using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42A24DF0E9B30696, NameHash = 0xF848BA9A5DFC4197)]
    public class GcCreatureTypes : NMSTemplate
    {
        // size: 0x2F
        public enum CreatureTypeEnum {
            None, Bird, FlyingLizard, FlyingSnake, Butterfly, FlyingBeetle, Beetle, Fish, Shark, Crab, 
            Snake, Dino, Antelope, Rodent, Cat, Fiend, Drone, Quad, Walker, Predator, 
            PlayerPredator, Prey, Passive, FishPredator, FishPrey, FiendFishSmall, FiendFishBig, Jellyfish, LandJellyfish, RockCreature, 
            MiniFiend, Floater, Scuttler, Slug, MiniDrone, SpaceFloater, Weird, SeaSnake, SandWorm, ProtoRoller, 
            ProtoFlyer, ProtoDigger, Plough, Digger, Drill, Brainless, Pet
        }
        public CreatureTypeEnum CreatureType;
    }
}