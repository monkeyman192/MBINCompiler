namespace libMBIN.Models.Structs
{
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        public int CharacterState;
        public string[] CharacterStateValues()
        {
            return new[] { "Idle", "Jog", "JogUphill", "JogDownhill", "SteepSlope", "Sliding", "Run",
                           "Airborne", "JetpackBoost", "Swimming", "Death", "FullBodyOverride" };
        }
    }
}
