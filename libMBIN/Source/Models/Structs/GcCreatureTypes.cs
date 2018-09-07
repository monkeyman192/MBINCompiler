namespace libMBIN.Models.Structs
{
    public class GcCreatureTypes : NMSTemplate
    {
		public enum CreatureTypeEnum { None, Bird, FlyingLizard, FlyingSnake, Butterfly, Beetle, Fish, Shark, Crab, Snake, Dino, Antelope, Rodent, Cat, Fiend, Drone, Quad, Walker, Predator, PlayerPredator, Prey, Passive, Brainless }
		public CreatureTypeEnum CreatureType;
    }
}
