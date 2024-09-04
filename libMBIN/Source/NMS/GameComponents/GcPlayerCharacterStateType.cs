namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFCC59A6CF5F883B, NameHash = 0xB4F01F64)]
    public class GcPlayerCharacterStateType : NMSTemplate
    {
        // size: 0x13
        public enum CharacterStateEnum : uint {
            Idle,
            Jog,
            JogUphill,
            JogDownhill,
            SteepSlope,
            Sliding,
            Run,
            Airborne,
            JetpackBoost,
            RocketBoots,
            Riding,
            Swimming,
            SwimmingJetpack,
            Death,
            FullBodyOverride,
            InSpace,
            LowGWalk,
            LowGRun,
            Fishing,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CharacterStateEnum CharacterState;
    }
}
