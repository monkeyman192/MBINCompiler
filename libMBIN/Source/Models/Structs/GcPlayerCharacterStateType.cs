namespace libMBIN.Models.Structs
{
    public class GcPlayerCharacterStateType : NMSTemplate
    {
		public enum CharacterStateEnum { Idle, Jog, JogUphill, JogDownhill, SteepSlope, Sliding, Run, Airborne, JetpackBoost, Swimming, Death, FullBodyOverride }
		public CharacterStateEnum CharacterState;
    }
}
