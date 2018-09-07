namespace libMBIN.Models.Structs
{
    public class GcCreatureIkType : NMSTemplate
    {
		public enum CreatureIkTypeEnum { Foot, Hinge_X, Hinge_Y, Hinge_Z, Locked, Head, Toe, SpaceshipFoot, SpaceshipToe }
		public CreatureIkTypeEnum CreatureIkType;
    }
}
